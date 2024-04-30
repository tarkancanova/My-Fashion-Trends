using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocksButtonController : MonoBehaviour
{
    [SerializeField] private ModelSocksController _modelSocksController;
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
        _modelSocksController.ChangeSocksModel(shoesIndex);
    }
}
