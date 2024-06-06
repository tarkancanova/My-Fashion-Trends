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
    private Button _button;
    [SerializeField] private BackgroundManager _backgroundManager;
    [SerializeField] private ButtonListener _buttonListener;

    private void OnEnable()
    {
        _button = GetComponent<Button>();
        if (_button != null)
        {
            _button.onClick.AddListener(OnClickButton);
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
        _button.onClick.RemoveListener(_buttonListener.LevelProgressionOnClick);
    }

}
