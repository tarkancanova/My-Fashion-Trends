using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgressionBar : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    private int _currentXP;
    private int _level;
    private int _neededXPForLevelUp;
    public TMP_Text _levelText;
    private Slider _slider;
    [SerializeField] private GameObject _completionBar;
    private Slider _completionSlider;
    [SerializeField] private float smoothDuration = 0.5f;

    private Coroutine _smoothFillCoroutine;

    private void Awake()
    {
        _level = _levelData.level;
        _currentXP = _levelData.playerXP;
        _neededXPForLevelUp = _level;
        _slider = this.GetComponent<Slider>();
        _completionSlider = _completionBar.GetComponent<Slider>();
        FillTheBarInstantly();
    }

    private void Update()
    {
        _neededXPForLevelUp = _level;
        _levelData.level = _level;
        _levelData.playerXP = _currentXP;
        _levelText.text = "Level: " + _levelData.level;
    }

    public void UpdateXP() //updates XP if progression bar is not full.
    {
        if (_completionSlider.value == 1) return;

        _currentXP += 1;
        FillTheBar();

        if (_currentXP >= _neededXPForLevelUp)
        {
            LevelUp();
        }
    }

    private void FillTheBar() //Fills the bar, if coroutine is still running stops it to prevent bugs on smooth filling.
    {
        float targetValue = (float)_currentXP / (float)_neededXPForLevelUp;

        if (_smoothFillCoroutine != null)
        {
            StopCoroutine(_smoothFillCoroutine);
        }

        _smoothFillCoroutine = StartCoroutine(SmoothFill(targetValue));
    }

    private void FillTheBarInstantly() //Changes the slider value based on the ratio of current XP to needed XP.
    {
        _slider.value = (float)_currentXP / (float)_neededXPForLevelUp;
    }

    private IEnumerator SmoothFill(float targetValue) //Makes the filling of bar smoother.
    {
        float startValue = _slider.value;
        float elapsedTime = 0f;

        while (elapsedTime < smoothDuration)
        {
            elapsedTime += Time.deltaTime;
            _slider.value = Mathf.Lerp(startValue, targetValue, elapsedTime / smoothDuration);
            yield return null;
        }

        _slider.value = targetValue;
    }

    public void LevelUp() //Level up logic sent to buttons as a listener.
    {
        if (_currentXP >= _neededXPForLevelUp)
        {
            _level += 1;
            _currentXP = 0;
            _smoothFillCoroutine = null;
            Debug.Log(_currentXP);
            _neededXPForLevelUp = _level;
            FillTheBarInstantly();
            _slider.value = 0;
        }
    }
}
