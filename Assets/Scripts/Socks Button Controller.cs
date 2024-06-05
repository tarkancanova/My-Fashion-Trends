using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocksButtonController : MonoBehaviour
{
    [SerializeField] private ModelSocksController _modelSocksController;
    public string category;
    [SerializeField] private GameObject _progressionBar;
    public int shoesIndex;
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
        _modelSocksController.ChangeSocksModel(shoesIndex);
        _progressionBar.GetComponent<CompletionBar>().AssignClickedCategory(category);
        _progressionBar.GetComponent<CompletionBar>().FillTheBar();
        _levelBar.GetComponent<LevelProgressionBar>().UpdateXP();
    }
}
