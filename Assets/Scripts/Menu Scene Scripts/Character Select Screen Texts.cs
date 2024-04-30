using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSelectScreenTexts : MonoBehaviour
{
    [SerializeField] private TMP_Text _selectedCharacterText;

    private void Update()
    {
        _selectedCharacterText.text = "Selected character: " + PlayerPrefs.GetInt("Character");
    }
}
