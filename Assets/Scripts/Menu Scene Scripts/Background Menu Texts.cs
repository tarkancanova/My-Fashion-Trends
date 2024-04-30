using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BackgroundMenuTexts : MonoBehaviour
{
    [SerializeField] private TMP_Text _selectedBackgroundText;

    private void Update()
    {
        _selectedBackgroundText.text = "Selected background: " + PlayerPrefs.GetInt("Background");
    }
}
