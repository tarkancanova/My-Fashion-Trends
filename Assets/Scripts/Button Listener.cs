using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListener : MonoBehaviour
{
    [SerializeField] private GameObject _levelBar;

    public void LevelProgressionOnClick()
    {
        _levelBar.GetComponent<LevelProgressionBar>().UpdateXP();
    }
}
