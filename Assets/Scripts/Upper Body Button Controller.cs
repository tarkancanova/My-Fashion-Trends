using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpperBodyButtonController : MonoBehaviour
{
    [SerializeField] private ModelUpperBodyController _modelUpperBodyController;
    public int upperBodyIndex;

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
    }
}
