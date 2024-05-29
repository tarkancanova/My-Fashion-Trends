using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeUpButtonController : MonoBehaviour
{
    [SerializeField] private ModelMakeUpController _modelMakeUpController;
    public int makeUpIndex;

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
        _modelMakeUpController.ChangeMKModel(makeUpIndex);
    }
}
