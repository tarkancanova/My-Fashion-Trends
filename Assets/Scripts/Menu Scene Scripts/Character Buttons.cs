using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButtons : MonoBehaviour
{
    public int characterIndex;

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
        PlayerPrefs.SetInt("Character", characterIndex);
    }
}
