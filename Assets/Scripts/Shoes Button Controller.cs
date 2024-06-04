using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoesButtonController : MonoBehaviour
{
    [SerializeField] private ModelShoesController _modelShoesController;
    [SerializeField] private GameObject _progressionBar;
    public string category;
    public int shoesIndex;

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
        _modelShoesController.ChangeShoesModel(shoesIndex);
        _progressionBar.GetComponent<CompletionBar>().AssignClickedCategory(category);
        _progressionBar.GetComponent<CompletionBar>().FillTheBar();
    }
}
