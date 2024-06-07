using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelAccesoryController : MonoBehaviour
{
    [SerializeField] private GameObject _accesoryModelsObject;
    private int _currentAccesoryIndex = 0;

    private GameObject[] _accesoryModels;

    //This script decides which accesory object will be set active based on the index it gets from buttons.

    private void Awake()
    {
        InitializeAccesoryModels();
    }

    public void InitializeAccesoryModels()
    {
        _accesoryModels = new GameObject[_accesoryModelsObject.transform.childCount];
        for (int i = 0; i < _accesoryModels.Length; i++)
        {
            _accesoryModels[i] = _accesoryModelsObject.transform.GetChild(i).gameObject;
        }
    }

    public void ChangeAccesoryModel(int newIndex)
    {

        _accesoryModels[_currentAccesoryIndex].SetActive(false);

        _accesoryModels[newIndex].SetActive(true);

        _currentAccesoryIndex = newIndex;
    }
}
