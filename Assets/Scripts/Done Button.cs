using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoneButton : MonoBehaviour
{
    [SerializeField] private GameObject _inGameUI;
    [SerializeField] private GameObject _takingPhotoUI;

    public void OnDoneButtonClick()
    {
        _inGameUI.SetActive(false);
        _takingPhotoUI.SetActive(true);
    }
}
