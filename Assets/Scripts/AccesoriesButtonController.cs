using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccesoriesButtonController : MonoBehaviour
{
    [SerializeField] private ModelAccesoryController _modelAccesoryController;
    public int accesoryIndex;

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
        _modelAccesoryController.ChangeAccesoryModel(accesoryIndex);
    }
}


