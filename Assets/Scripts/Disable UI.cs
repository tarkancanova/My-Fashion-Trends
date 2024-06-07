using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableUI : MonoBehaviour
{
    [SerializeField] private GameObject _mainUI;
    [SerializeField] private GameObject _nextLevel;

    //Disables UI for the screenshot, activates continue button 0.5 seconds after disabling UI (to give some time to screenshot capture tool) and then continues to "next level" screen.

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
