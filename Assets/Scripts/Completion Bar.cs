using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CompletionBar : MonoBehaviour
{
    private Image _image;
    private float _currentProgression;
    private float _maxProgression = 100;
    private float _progressAmountPerChange = 5;
    [SerializeField] private float _fillSpeed;
    [SerializeField] private GameObject _continueButton;

    private void Awake()
    {
        _image = GetComponent<Image>();
        _currentProgression = 0;
    }

    private void Update()
    {
        ActivateContinueButton();
    }

    public void UpdateProgression()
    {
        _currentProgression += _progressAmountPerChange;
        FillTheBar();
    }

    public void FillTheBar()
    {
        
        float targetFillAmount = _currentProgression/_maxProgression;
        _image.DOFillAmount(targetFillAmount, _fillSpeed);
    }

    private void ActivateContinueButton()
    {
        if (_currentProgression >= _maxProgression)
        {
            _continueButton.SetActive(true);
        }
        else
            _continueButton.SetActive(false);
    }
}
