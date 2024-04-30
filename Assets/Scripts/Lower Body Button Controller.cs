using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LowerBodyButtonController : MonoBehaviour
{
    [SerializeField] private ModelLowerBodyController _modelLowerBodyController;
    public int lowerBodyIndex;

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
    }
}
