using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpperBodyButtonController : MonoBehaviour
{
    [SerializeField] private ModelUpperBodyController _modelUpperBodyController;
    [SerializeField] private GameObject _progressionBar;
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
        _modelUpperBodyController.ChangeUpperBodyModel(upperBodyIndex);
        _progressionBar.GetComponent<CompletionBar>().AssignClickedCategory(category);
        _progressionBar.GetComponent<CompletionBar>().FillTheBar();
    }
}
