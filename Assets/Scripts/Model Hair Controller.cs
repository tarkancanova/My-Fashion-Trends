using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class ModelHairController : MonoBehaviour
{
    [SerializeField] private GameObject _hairModelsObject;
    private int _currentHairIndex = 0;

    private GameObject[] _hairModels;

    //This script decides which hair object will be set active based on the index it gets from buttons.


    private void Awake()
    {
        InitializeHairModels();
    }

    public void InitializeHairModels()
    {
        _hairModels = new GameObject[_hairModelsObject.transform.childCount];
        for (int i = 0; i < _hairModels.Length; i++)
        {
            _hairModels[i] = _hairModelsObject.transform.GetChild(i).gameObject;
        }
    }

    public void ChangeHairModel(int newIndex)
    {
        _hairModels[_currentHairIndex].SetActive(false);

        _hairModels[newIndex].SetActive(true);

        _currentHairIndex = newIndex;
    }
}
