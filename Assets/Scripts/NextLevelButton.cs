using UnityEngine;
using UnityEngine.UI;

public class NextLevelButton : MonoBehaviour
{
    [SerializeField] private GameObject _levelCompletedObject;
    [SerializeField] private GameObject _backgroundSelectionObject;
    [SerializeField] private ProgressionData _progData;
    [SerializeField] private GameObject _progressionBar;
    [SerializeField] public ModelUpperBodyController _modelUpperBodyController;
    [SerializeField] public ModelLowerBodyController _modelLowerBodyController;
    [SerializeField] public ModelShoesController _modelShoesController;
    [SerializeField] public ModelHairController _modelHairController;
    //This script takes player back to background selection screen.
    //DeactivateAllChildren deactivates the children of given parent object and used in this script to deactivate dress, accesory and hair models.

    public void OnNextLevelButtonClick()
    {
        _levelCompletedObject.SetActive(false);
        _backgroundSelectionObject.SetActive(true);
        _progData.playerProgression += 1;
        _progressionBar.GetComponent<Slider>().value = 0;
        PlayerPrefs.DeleteKey("Background");
        SaveData.Instance.Save();
        UnlockScenes.Instance.UnlockScene();
        SetBasicOutfit();
        RVManager.Instance._accesoryButton.SetActive(false);
        RVManager.Instance._accesoryButtonReward.SetActive(true);
    }

    public void SetBasicOutfit()
    {
        _modelHairController.SetBasicOutfit();
        _modelUpperBodyController.SetBasicOutfit();
        _modelLowerBodyController.SetBasicOutfit();
        _modelShoesController.SetBasicOutfit();
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
