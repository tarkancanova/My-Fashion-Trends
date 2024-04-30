using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundButtons : MonoBehaviour
{
    public int backgroundIndex;

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
        PlayerPrefs.SetInt("Background", backgroundIndex);
    }
}
