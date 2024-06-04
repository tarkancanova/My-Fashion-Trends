using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HairButtonController : MonoBehaviour
{
    [SerializeField] private ModelHairController _modelHairController;
    [SerializeField] private GameObject _progressionBar;
    public string category;
    public int hairIndex;

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
        _modelHairController.ChangeHairModel(hairIndex);
        _progressionBar.GetComponent<CompletionBar>().AssignClickedCategory(category);
        _progressionBar.GetComponent<CompletionBar>().FillTheBar();
    }
}