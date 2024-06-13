using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class ModelLowerBodyController : MonoBehaviour
{
    [SerializeField] private GameObject _lowerBodyModelsObject;
    [SerializeField] public ModelSocksController _modelSocksController;
    public int _currentLowerBodyIndex = 0;

    private GameObject[] _lowerBodyModels;

    //This script decides which lowerbody object will be set active based on the index it gets from buttons.

    private void Awake()
    {
        InitializeLowerBodyModels();
    }

    public void InitializeLowerBodyModels()
    {
        _lowerBodyModels = new GameObject[_lowerBodyModelsObject.transform.childCount];
        for (int i = 0; i < _lowerBodyModels.Length; i++)
        {
            _lowerBodyModels[i] = _lowerBodyModelsObject.transform.GetChild(i).gameObject;
        }
    }

    public void ChangeLowerBodyModel(int newIndex)
    {

        _lowerBodyModels[_currentLowerBodyIndex].SetActive(false);

        _lowerBodyModels[newIndex].SetActive(true);

        _currentLowerBodyIndex = newIndex;

        for (int i = 11; i >= 6; i--)
        {
           if(_currentLowerBodyIndex == i)
            {
                _modelSocksController.ChangeSocksModel(7);
            }
        }


    }

    public void RemoveAllLowerBody()
    {
        foreach (var model in _lowerBodyModels)
        {
            model.gameObject.SetActive(false);
        }
    }
}
