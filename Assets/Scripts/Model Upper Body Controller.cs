using UnityEngine;

public class ModelUpperBodyController : MonoBehaviour
{
    [SerializeField] private GameObject _upperBodyModelsObject;
    private int _currentUpperBodyIndex = 0;

    private GameObject[] _upperBodyModels;

    //This script decides which upperbody object will be set active based on the index it gets from buttons.

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

    public void SetBasicOutfit()
    {
        ChangeUpperBodyModel(16);
    }

    public void RemoveAllUpperBody()
    {
        foreach (var model in _upperBodyModels)
        {
            model.gameObject.SetActive(false);
        }
    }
}
