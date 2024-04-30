using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIButtonController : MonoBehaviour
{
    [SerializeField] private GameObject _upperBodyUI;
    [SerializeField] private GameObject _lowerBodyUI;
    [SerializeField] private GameObject _shoesUI;
    [SerializeField] private GameObject _socksUI;
    [SerializeField] private GameObject _hairUI;
    public int uIndex;

    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnClickButton);
        }
    }

    private void OnClickButton()
    {
        UIIndexing(uIndex);
    }

    private void UIIndexing(int index) 
    {
        switch (uIndex)
        {
            case 0:
                _upperBodyUI.SetActive(true);
                _lowerBodyUI.SetActive(false);
                _shoesUI.SetActive(false);
                _socksUI.SetActive(false);
                _hairUI.SetActive(false);
                break;
            case 1:
                _upperBodyUI.SetActive(false);
                _lowerBodyUI.SetActive(true);
                _shoesUI.SetActive(false);
                _socksUI.SetActive(false);
                _hairUI.SetActive(false);
                break;
            case 2:
                _upperBodyUI.SetActive(false);
                _lowerBodyUI.SetActive(false);
                _shoesUI.SetActive(true);
                _socksUI.SetActive(false);
                _hairUI.SetActive(false);
                break;            
            case 3:
                _upperBodyUI.SetActive(false);
                _lowerBodyUI.SetActive(false);
                _shoesUI.SetActive(false);
                _socksUI.SetActive(true);
                _hairUI.SetActive(false);
                break;            
            case 4:
                _upperBodyUI.SetActive(false);
                _lowerBodyUI.SetActive(false);
                _shoesUI.SetActive(false);
                _socksUI.SetActive(false);
                _hairUI.SetActive(true);
                break;
        }
    }
}
