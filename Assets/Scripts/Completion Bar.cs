using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CompletionBar : MonoBehaviour
{
    [SerializeField] private float _fillSpeed = 0.5f; // Default fill speed
    [SerializeField] private GameObject _continueButton;
    private string lastClickedCategory;
    public string clickedCategory;
    [SerializeField] private GameObject _heartParticle;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        lastClickedCategory = "Initial value";
    }

    private void Update()
    {
        ChangeSliderButton();
    }


    public void FillTheBar()
    {
        if (clickedCategory == lastClickedCategory) return;
        else
        {
            float targetValue = _slider.value + 0.15f;
            _slider.DOValue(targetValue, _fillSpeed).SetEase(Ease.InOutQuad);
            AssignLastClickedCategory();
        }
    }

    public void AssignClickedCategory(string category)
    {
        clickedCategory = category;
    }

    public void AssignLastClickedCategory()
    {
        lastClickedCategory = clickedCategory;
    }

    public void ActivateContinueButton()
    {
        //if (_slider.value > .92f && _slider.value < 1)
        //{
        //    _heartParticle.GetComponent<ParticleSystem>().Play();
        //}
    }

    private void ChangeSliderButton()
    {
        if (_slider.value > .98f && _slider.value < 1)
        {
            _heartParticle.GetComponent<ParticleSystem>().Play();
        }

        if (_slider.value == 1)
        {
            _continueButton.SetActive(true);
        }
        else
        {
            _continueButton.SetActive(false);
        }
    }
}
