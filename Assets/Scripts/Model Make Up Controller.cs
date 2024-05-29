using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMakeUpController : MonoBehaviour
{
    [SerializeField] private GameObject _makeupsObject;
    private int _currentMKIndex = 0;

    private GameObject[] _mkModels;

    private void Awake()
    {
        InitializeMKModels();
    }

    public void InitializeMKModels()
    {
        _mkModels = new GameObject[_makeupsObject.transform.childCount];
        for (int i = 0; i < _mkModels.Length; i++)
        {
            _mkModels[i] = _makeupsObject.transform.GetChild(i).gameObject;
        }
    }

    public void ChangeMKModel(int newIndex)
    {
        _mkModels[_currentMKIndex].SetActive(false);

        _mkModels[newIndex].SetActive(true);

        _currentMKIndex = newIndex;
    }
}
