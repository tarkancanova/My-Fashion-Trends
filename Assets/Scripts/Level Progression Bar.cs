using System.Collections;
using System.Collections.Generic;
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


    private void Awake()
    {
        _level = _levelData.level;
        _currentXP = _levelData.playerXP;
        _neededXPForLevelUp = _level; // Set _neededXPForLevelUp here
        _slider = this.GetComponent<Slider>();
        _completionSlider = _completionBar.GetComponent<Slider>();
        FillTheBar();
    }

    private void Update()
    {
        _neededXPForLevelUp = _level;
        _levelData.level = _level;
        _levelData.playerXP = _currentXP;
        _levelText.text = "Level: " + _levelData.level;
        LevelUp();
        Debug.Log(_neededXPForLevelUp + " " + _currentXP);
    }

    public void UpdateXP()
    {
        if (_completionSlider.value == 1) return;

        _currentXP += 1;
        FillTheBar();
    }

    private void FillTheBar()
    {
        _slider.value = (float)_currentXP / (float)_neededXPForLevelUp;
    }

    private void LevelUp()
    {
        if (_currentXP == _neededXPForLevelUp)
        {
            _level += 1;
            _currentXP = 0;
            _slider.value = 0;
        }
    }
}