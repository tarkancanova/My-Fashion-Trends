using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListener : MonoBehaviour
{
    [SerializeField] private GameObject _levelBar;

    //To update the level bar's XP, there has been a need for connection between level bar and buttons because of the way button logic implemented. This script provides the connection.

    public void LevelProgressionOnClick()
    {
        LevelProgressionBar levelProgressionBar = _levelBar.GetComponent<LevelProgressionBar>();

        levelProgressionBar.UpdateXP();
    }
}
