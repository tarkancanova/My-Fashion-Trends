using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DressButtonController : MonoBehaviour
{
    [SerializeField] private ModelDressController _modelDressController;
    public int dressIndex;

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
        _modelDressController.ChangeDressModel(dressIndex);
        SoundManager.Instance.PlayDressingEffect(); // SFX
    }
}
