using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _firstChar;
    [SerializeField] private GameObject _secondChar;
    [SerializeField] private GameObject _thirdChar;

    private void Awake()
    {
        switch (PlayerPrefs.GetInt("Character"))
        {
            case 1:
                _firstChar.SetActive(true);
                break;            
            case 2:
                _secondChar.SetActive(true);
                break;            
            case 3:
                _thirdChar.SetActive(true);
                break;
        }
    }
}
