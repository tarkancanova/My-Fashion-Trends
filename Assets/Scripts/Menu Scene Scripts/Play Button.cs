using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private GameObject _startCanvas;
    [SerializeField] private GameObject _characterSelectionCanvas;

    public void OnPlayButtonClicked()
    {
        _startCanvas.SetActive(false);
        _characterSelectionCanvas.SetActive(true);
    }
}
