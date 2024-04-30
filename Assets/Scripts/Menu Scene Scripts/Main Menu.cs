using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _startCanvas;
    [SerializeField] private GameObject _characterSelectionCanvas;
    [SerializeField] private GameObject _backgroundSelectionCanvas;
    [SerializeField] private int _selectedCharacter;
    [SerializeField] private int _selectedBackground;
    [SerializeField] private TMP_Text _selectedCharacterText;
    [SerializeField] private TMP_Text _selectedBackgroundText;


    private void Awake()
    {
        //_selectedCharacter = ...
        //_selectedBackground = ...
        UpdateSelectedCharacterText();
        UpdateSelectedBackgroundText();
        
    }

    //START BUTTON SCREEN
    public void OnStartButtonClicked()
    {
        _startCanvas.SetActive(false);
        _characterSelectionCanvas.SetActive(true);
    }


    //----------------------------------------------------------------------------------

    //CHARACTER SELECTION SCREEN
    public void OnCharacterSelectionScreenContinueButtonPressed()
    {
        _characterSelectionCanvas.SetActive(false);
        _backgroundSelectionCanvas.SetActive(true);
        
        switch (_selectedCharacter)
        {
            case 1:
                PlayerPrefs.SetInt("Character", _selectedCharacter);
                break;
            case 2:
                PlayerPrefs.SetInt("Character", _selectedCharacter);
                break;
            case 3:
                PlayerPrefs.SetInt("Character", _selectedCharacter);
                break;
        }

    }

    public void UpdateSelectedCharacterText()
    {
        if (_selectedCharacter == 0)
        {
            _selectedCharacterText.text = "No character has been selected.";
        }
        else
        {
            _selectedCharacterText.text = "Selected character: " + _selectedCharacter;
        }
    }

    public void OnFirstCharacterButtonPressed()
    {
        _selectedCharacter = 1;
    }    
    public void OnSecondCharacterButtonPressed()
    {
        _selectedCharacter = 2;
    }   
    public void OnThirdCharacterButtonPressed()
    {
        _selectedCharacter = 3;
    }


    //--------------------------------------------------------------
    
    //BACKGROUND SCREEN
    public void OnBackgroundSelectionContinueButtonPressed()
    {
        switch (_selectedBackground)
        {
            case 1:
                PlayerPrefs.SetInt("Background", _selectedBackground);
                break;
            case 2:
                PlayerPrefs.SetInt("Background", _selectedBackground);
                break;
            case 3:
                PlayerPrefs.SetInt("Background", _selectedBackground);
                break;
        }

        SceneManager.LoadScene("Game Scene");

    }
    public void OnFirstBackgroundButtonPressed()
    {
        _selectedBackground = 1;
    }
    public void OnSecondBackgroundButtonPressed()
    {
        _selectedBackground = 2;
    }
    public void OnThirdBackgroundButtonPressed()
    {
        _selectedBackground = 3;
    }

    public void UpdateSelectedBackgroundText()
    {
        if (_selectedBackground == 0)
        {
            _selectedBackgroundText.text = "No background has been selected.";
        }
        else
        {
            _selectedBackgroundText.text = "Selected background: " + _selectedBackground;
        }
    }

}
