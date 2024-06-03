using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundButtons : MonoBehaviour
{
    public int backgroundIndex;
    [SerializeField] private GameObject _backgroundsObject;
    [SerializeField] private GameObject _backgroundSelectionUI;
    [SerializeField] private GameObject _inGameUI;

    private void Awake()
    {
        PlayerPrefs.SetInt("Background", 1);
    }

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
        _backgroundSelectionUI.SetActive(false);
        for(int i = 0; i < _backgroundsObject.transform.childCount; i++)
        {
            _backgroundsObject.transform.GetChild(i).gameObject.SetActive(false);
        }
        _backgroundsObject.transform.GetChild(backgroundIndex).gameObject.SetActive(true);
        _inGameUI.SetActive(true);
    }
}
