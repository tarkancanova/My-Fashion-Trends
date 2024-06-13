using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSocksController : MonoBehaviour
{
    [SerializeField] private GameObject _socksModelsObject;
    [SerializeField] public ModelLowerBodyController _modelLowerBodyController;
    private int _currentSocksIndex = 0;

    private GameObject[] _socksModels;

    //This script decides which socks object will be set active based on the index it gets from buttons.

    private void Awake()
    {
        InitializeSocksModels();
    }

    public void InitializeSocksModels()
    {
        _socksModels = new GameObject[_socksModelsObject.transform.childCount];
        for (int i = 0; i < _socksModels.Length; i++)
        {
            _socksModels[i] = _socksModelsObject.transform.GetChild(i).gameObject;
        }
    }

    public void ChangeSocksModel(int newIndex)
    {
        _socksModels[_currentSocksIndex].SetActive(false);

        _socksModels[newIndex].SetActive(true);

        _currentSocksIndex = newIndex;

        for (int i = 11; i >= 6; i--)
        {
            if (_modelLowerBodyController._currentLowerBodyIndex == i && _currentSocksIndex < 6)
            {
               _modelLowerBodyController.ChangeLowerBodyModel(15);
            }
        }
    }
}
