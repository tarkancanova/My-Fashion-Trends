using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LowerBodyButtonController : MonoBehaviour
{
    [SerializeField] private ModelLowerBodyController _modelLowerBodyController;
    [SerializeField] private GameObject _progressionBar;
    public string category;
    public int lowerBodyIndex;
    [SerializeField] private GameObject _levelBar;
    [SerializeField] private LevelData _levelData;

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
        _modelLowerBodyController.ChangeLowerBodyModel(lowerBodyIndex);
        _progressionBar.GetComponent<CompletionBar>().AssignClickedCategory(category);
        _progressionBar.GetComponent<CompletionBar>().FillTheBar();
        _levelBar.GetComponent<LevelProgressionBar>().UpdateXP();
    }
}
