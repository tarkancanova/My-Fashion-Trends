using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HairButtonController : MonoBehaviour
{
    [SerializeField] private ModelHairController _modelHairController;
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
    }
}