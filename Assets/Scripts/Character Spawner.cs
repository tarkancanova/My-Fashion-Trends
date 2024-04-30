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
                Instantiate(_firstChar);
                break;            
            case 2:
                Instantiate(_secondChar);
                break;            
            case 3:
                Instantiate(_thirdChar);
                break;
        }
    }
}
