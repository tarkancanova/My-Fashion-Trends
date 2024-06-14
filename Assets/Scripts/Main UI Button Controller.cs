using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIButtonController : Singleton<MainUIButtonController>
{
    [SerializeField] private GameObject _upperBodyUI;
    [SerializeField] private GameObject _lowerBodyUI;
    [SerializeField] private GameObject _shoesUI;
    [SerializeField] private GameObject _socksUI;
    [SerializeField] private GameObject _hairUI;
    [SerializeField] private GameObject _objectUI;
    private GameObject[] _userInterfaces;
    public int uIndex;
    private int _currentUIndex = 0;


    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnClickButton);
        }
    }

    public void OnClickButton()
    {
        ChangeUI(uIndex);
    }


    public void ChangeUI(int newIndex)
    {
        for (int i = 0; i < _objectUI.transform.childCount; i++)
        {
            if (i != newIndex)
            {
                _objectUI.transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        _objectUI.transform.GetChild(newIndex).gameObject.SetActive(true);

        _currentUIndex = newIndex;
    }

    public void ChangeUIReward(int newIndex)
    {
        for (int i = 0; i < _objectUI.transform.childCount; i++)
        {
            if (i != newIndex)
            {
                _objectUI.transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        _objectUI.transform.GetChild(newIndex).gameObject.SetActive(true);

        _currentUIndex = newIndex;
    }
}


//private void ActivateChosen(int index) 
//    {
//        //switch (uIndex)
//        //{
//        //    case 0:
//        //        _upperBodyUI.SetActive(true);
//        //        _lowerBodyUI.SetActive(false);
//        //        _shoesUI.SetActive(false);
//        //        _socksUI.SetActive(false);
//        //        _hairUI.SetActive(false);
//        //        break;
//        //    case 1:
//        //        _upperBodyUI.SetActive(false);
//        //        _lowerBodyUI.SetActive(true);
//        //        _shoesUI.SetActive(false);
//        //        _socksUI.SetActive(false);
//        //        _hairUI.SetActive(false);
//        //        break;
//        //    case 2:
//        //        _upperBodyUI.SetActive(false);
//        //        _lowerBodyUI.SetActive(false);
//        //        _shoesUI.SetActive(true);
//        //        _socksUI.SetActive(false);
//        //        _hairUI.SetActive(false);
//        //        break;            
//        //    case 3:
//        //        _upperBodyUI.SetActive(false);
//        //        _lowerBodyUI.SetActive(false);
//        //        _shoesUI.SetActive(false);
//        //        _socksUI.SetActive(true);
//        //        _hairUI.SetActive(false);
//        //        break;            
//        //    case 4:
//        //        _upperBodyUI.SetActive(false);
//        //        _lowerBodyUI.SetActive(false);
//        //        _shoesUI.SetActive(false);
//        //        _socksUI.SetActive(false);
//        //        _hairUI.SetActive(true);
//        //        break;
//        //}

//        _objectUI.transform.GetChild(index).gameObject.SetActive(true);
//    }

