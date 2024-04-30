using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSelection : MonoBehaviour
{
    [SerializeField] GameObject _firstBackground;
    [SerializeField] GameObject _secondBackground;
    [SerializeField] GameObject _thirdBackground;


    private void Awake()
    {
        switch (PlayerPrefs.GetInt("Background"))
        {
            case 1:
                _firstBackground.SetActive(true); break;            
            case 2:
                _secondBackground.SetActive(true); break;
            case 3:
                _thirdBackground.SetActive(true); break;
        }
    }
}
