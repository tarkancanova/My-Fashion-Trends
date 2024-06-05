using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpperBodyButtonController : MonoBehaviour
{
    [SerializeField] private ModelUpperBodyController _modelUpperBodyController;
    [SerializeField] private GameObject _progressionBar;
    [SerializeField] private GameObject _levelBar;
    [SerializeField] private LevelData _levelData;
    public int upperBodyIndex;
    public string category;

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
        if (_levelData.level < 5 && (upperBodyIndex == 5 || upperBodyIndex == 6)) //an example of level-locking a dress. do it like this!!!!!!
        {
            return;
        }


        _modelUpperBodyController.ChangeUpperBodyModel(upperBodyIndex);
        _progressionBar.GetComponent<CompletionBar>().AssignClickedCategory(category);
        _progressionBar.GetComponent<CompletionBar>().FillTheBar();
        _levelBar.GetComponent<LevelProgressionBar>().UpdateXP();
    }
}
