using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableUI : MonoBehaviour
{
    [SerializeField] private GameObject _mainUI;
    [SerializeField] private GameObject _dressMenu;
    [SerializeField] private GameObject _completionBar;
    [SerializeField] private GameObject _continueButton;
    [SerializeField] private GameObject _continueToMainMenu;



    public void OnContinueButtonClick()
    {
        CloseUI();
        Invoke(nameof(ActivateContinueButton), 0.5f);
    }

    public void CloseUI()
    {
        _mainUI.SetActive(false);
        _completionBar.SetActive(false);
        _dressMenu.SetActive(false);
        _continueButton.SetActive(false);

    }

    public void ActivateContinueButton()
    {
        _continueToMainMenu.SetActive(true);
    }
}
