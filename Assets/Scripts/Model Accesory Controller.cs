using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelAccesoryController : MonoBehaviour
{
    [SerializeField] private GameObject _accesoryModelsObject;
    [SerializeField] public ModelHairController _hairModels;
    public int _currentAccesoryIndex = 0;
    public bool _accesoryChanged;

    public GameObject[] _accesoryModels;

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

        for (int i = 4; i >= 0; i--)
        {
            if (i == newIndex)
            {
                _hairModels.ChangeHairModel(12);
            }
        }

        if(newIndex == 9 || newIndex == 10)
        {
            _hairModels.ChangeHairModel(12);
        }
    }
}
