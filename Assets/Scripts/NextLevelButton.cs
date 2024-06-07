using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelButton : MonoBehaviour
{
    [SerializeField] private GameObject _levelCompletedObject;
    [SerializeField] private GameObject _backgroundSelectionObject;
    [SerializeField] private ProgressionData _progData;
    [SerializeField] private GameObject _progressionBar;
    [SerializeField] private GameObject _clothesObject;
    [SerializeField] private GameObject _hairObject;
    [SerializeField] private GameObject _accObject;

    //This script takes player back to background selection screen.
    //DeactivateAllChildren deactivates the children of given parent object and used in this script to deactivate dress, accesory and hair models.

    public void OnNextLevelButtonClick()
    {
        _levelCompletedObject.SetActive(false);
        _backgroundSelectionObject.SetActive(true);
        _progData.playerProgression += 1;
        _progressionBar.GetComponent<Slider>().value = 0;
        for (int i = 0; i < _clothesObject.transform.childCount; i++)
        {
            DeactivateAllChildren(_clothesObject.transform.GetChild(i));
        }
        DeactivateAllChildren(_hairObject.transform);
        DeactivateAllChildren(_accObject.transform);
        PlayerPrefs.DeleteKey("Background");
    }

    public void DeactivateAllChildren(Transform parent)
    {
        foreach (Transform child in parent)
        {
            DeactivateAllChildren(child);  // Recursive call for all descendants
            child.gameObject.SetActive(false);  // Deactivate the child object
        }
    }
}
