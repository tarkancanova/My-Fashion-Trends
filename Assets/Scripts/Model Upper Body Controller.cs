using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class ModelUpperBodyController : MonoBehaviour
{
    [SerializeField] private GameObject _upperBodyModelsObject;
    private int _currentUpperBodyIndex = 0;

    private GameObject[] _upperBodyModels;

    private void Awake()
    {
        InitializeUpperBodyModels();
    }

    public void InitializeUpperBodyModels()
    {
        _upperBodyModels = new GameObject[_upperBodyModelsObject.transform.childCount];
        for (int i = 0; i < _upperBodyModels.Length; i++)
        {
            _upperBodyModels[i] = _upperBodyModelsObject.transform.GetChild(i).gameObject;
        }
    }

    public void ChangeUpperBodyModel(int newIndex)
    {
        _upperBodyModels[_currentUpperBodyIndex].SetActive(false);

        _upperBodyModels[newIndex].SetActive(true);

        _currentUpperBodyIndex = newIndex;
    }
}
