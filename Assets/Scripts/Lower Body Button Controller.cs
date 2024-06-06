using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        _modelLowerBodyController.ChangeLowerBodyModel(lowerBodyIndex);
        _progressionBar.GetComponent<CompletionBar>().AssignClickedCategory(category);
        _progressionBar.GetComponent<CompletionBar>().FillTheBar();
        _button.onClick.RemoveListener(_buttonListener.LevelProgressionOnClick);


    }

}
