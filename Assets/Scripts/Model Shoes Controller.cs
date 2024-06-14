using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelShoesController : MonoBehaviour
{
    [SerializeField] private GameObject _shoesModelsObject;
    private int _currentShoesIndex = 0;

    private GameObject[] _shoesModels;

    //This script decides which shoes object will be set active based on the index it gets from buttons.

    private void Awake()
    {
        InitializeShoeModels();
    }

    public void InitializeShoeModels()
    {
        _shoesModels = new GameObject[_shoesModelsObject.transform.childCount];
        for (int i = 0; i < _shoesModels.Length; i++)
        {
            _shoesModels[i] = _shoesModelsObject.transform.GetChild(i).gameObject;
        }
    }

    public void ChangeShoesModel(int newIndex)
    {
        _shoesModels[_currentShoesIndex].SetActive(false);

        _shoesModels[newIndex].SetActive(true);

        _currentShoesIndex = newIndex;
    }

    public void SetBasicOutfit()
    {
        ChangeShoesModel(11);
    }
}
