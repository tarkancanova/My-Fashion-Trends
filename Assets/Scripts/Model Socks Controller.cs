using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSocksController : MonoBehaviour
{
    [SerializeField] private GameObject _socksModelsObject;
    private int _currentSocksIndex = 0;

    private GameObject[] _socksModels;

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
    }
}
