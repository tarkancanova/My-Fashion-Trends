using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CompletionBar : MonoBehaviour
{
    [SerializeField] private float _fillSpeed = 0.5f; // Default fill speed
    [SerializeField] private GameObject _continueButton;
    private string lastClickedCategory;
    public string clickedCategory;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
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
            float targetValue = _slider.value + 0.1f;
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

    private void ActivateContinueButton()
    {
        if (_slider.value >= 1)
        {
            _continueButton.SetActive(true);
        }
        else
        {
            _continueButton.SetActive(false);
        }
    }
}
