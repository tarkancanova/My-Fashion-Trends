using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class ModelLowerBodyController : MonoBehaviour
{
    [SerializeField] private GameObject _lowerBodyModelsObject;
    private int _currentLowerBodyIndex = 0;

    private GameObject[] _lowerBodyModels;

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

        
    }

    public void RemoveAllLowerBody()
    {
        foreach (var model in _lowerBodyModels)
        {
            model.gameObject.SetActive(false);
        }
    }
}
