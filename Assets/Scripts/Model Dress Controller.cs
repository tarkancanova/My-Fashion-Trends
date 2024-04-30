using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelDressController : MonoBehaviour
{
    [SerializeField] private ModelUpperBodyController _upperBodyController;
    [SerializeField] private ModelLowerBodyController _lowerBodyController;
    [SerializeField] private GameObject _dressModelsObject;
    private int _currentDressIndex = 0;

    private GameObject[] _dressModels;

    private void Awake()
    {
        InitializeDressModels();
    }

    public void InitializeDressModels()
    {
        _dressModels = new GameObject[_dressModelsObject.transform.childCount];
        for (int i = 0; i < _dressModels.Length; i++)
        {
            _dressModels[i] = _dressModelsObject.transform.GetChild(i).gameObject;
        }
    }

    public void ChangeDressModel(int newIndex)
    {
        UndressLowerBody();
        UndressUpperBody();

        _dressModels[_currentDressIndex].SetActive(false);

        _dressModels[newIndex].SetActive(true);

        _currentDressIndex = newIndex;
    }

    private void UndressLowerBody()
    {
        _lowerBodyController.RemoveAllLowerBody();
    }    
    private void UndressUpperBody()
    {
        _upperBodyController.RemoveAllUpperBody();
    }

    public void RemoveAllDress()
    {
        foreach (var model in _dressModels)
        {
            model.gameObject.SetActive(false);
        }
    }

}
