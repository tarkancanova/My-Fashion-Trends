using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private GameObject _backgroundSelectionUI;
    [SerializeField] private GameObject _backgroundsObject;
    [SerializeField] private GameObject _messageScreens;
    [SerializeField] private ProgressionData _progData;
    public List<Button> buttons = new List<Button>();
    [SerializeField] private ButtonListener _buttonListener;
    [SerializeField] private GameObject _gameScene;
    [SerializeField] private GameObject _interfacesObject;

    //assigns variables to background buttons and makes the background selection possible.

    private void Awake()
    {

    }

    private void Start()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            int index = i; // Store the current index value locally
            GameObject child = this.transform.GetChild(i).gameObject;
            Button button = child.GetComponent<Button>();

            if (button != null)
            {
                button.onClick.AddListener(() => OnClickButton(index)); // Use the local index variable
            }
        }


    }

    public void OnClickButton(int backgroundIndex) //first, checks the player progression to determine which backgrounds can be selected then sets the data for playerprefs,
                                                   //deactivates background selection screen and all the backgrounds, and activates the selected background. Finally, sets the in game UI active.
    {

        if (_progData.playerProgression < backgroundIndex) return;

        PlayerPrefs.SetInt("Background", backgroundIndex);

        _backgroundSelectionUI.SetActive(false);

        for (int i = 0; i < _backgroundsObject.transform.childCount; i++)
        {
            _backgroundsObject.transform.GetChild(i).gameObject.SetActive(false);
        }

        if (backgroundIndex >= 0 && backgroundIndex < _backgroundsObject.transform.childCount)
        {
            _backgroundsObject.transform.GetChild(backgroundIndex).gameObject.SetActive(true);
            ConceptNames.Instance.SetConceptNames(backgroundIndex);
        }

        foreach(Button button in buttons)
        {
            button.onClick.AddListener(_buttonListener.LevelProgressionOnClick);
        }

        _messageScreens.SetActive(true);
        _messageScreens.transform.GetChild(backgroundIndex).gameObject.SetActive(true);

    }
}
