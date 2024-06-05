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
    private string lastClickedCategory;
    public string clickedCategory;

    private void Awake()
    {
        _image = GetComponent<Image>();
        _currentProgression = 0;
        lastClickedCategory = "Initial value";
        
    }

    private void Update()
    {
        ActivateContinueButton();
    }

    public void FillTheBar()
    {
        if (clickedCategory == lastClickedCategory) return;
        else
        {
            this.GetComponent<Slider>().value += 0.05f;
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
