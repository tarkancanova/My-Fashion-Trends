using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableUI : MonoBehaviour
{
    [SerializeField] private GameObject _mainUI;
    [SerializeField] private GameObject _nextLevel;



    public void OnContinueButtonClick()
    {
        CloseUI();
        Invoke(nameof(ActivateContinueButton), 0.5f);
    }

    public void CloseUI()
    {
        _mainUI.SetActive(false);


    }

    public void ActivateContinueButton()
    {
        _nextLevel.SetActive(true);
    }
}
