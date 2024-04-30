using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableUI : MonoBehaviour
{
    [SerializeField] private GameObject _UI;


    public void CloseUI()
    {
        _UI.SetActive(false);
    }
}
