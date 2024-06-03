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
        this.GetComponent<Slider>().value += 0.05f;
    }

    private void ActivateContinueButton()
    {
        if (this.GetComponent<Slider>().value >= 1)
        {
            _continueButton.SetActive(true);
        }
        else
            _continueButton.SetActive(false);
    }
}
