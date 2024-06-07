using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [SerializeField] private ProgressionData _progressionData;
    [SerializeField] private LevelData _levelData;
    [SerializeField] private BackgroundManager _backgroundManager;
    private const string PLAYERPREFS_LEVEL = "Level";
    private const string PLAYERPREFS_XP = "XP";
    private const string PLAYERPREFS_PROGRESSION = "Progression";
    private const string BACKGROUND_SELECTION = "Background";

    //In OnEnable, sets the data from playerprefs to scriptableobject. In OnDisable, sets the data from scriptableobject to playerprefs.


    private void OnEnable()
    {
        if (PlayerPrefs.HasKey(PLAYERPREFS_XP))    _levelData.playerXP = PlayerPrefs.GetInt(PLAYERPREFS_XP, _levelData.playerXP);
        else _levelData.playerXP = 0;
        if (PlayerPrefs.HasKey(PLAYERPREFS_LEVEL)) _levelData.level = PlayerPrefs.GetInt(PLAYERPREFS_LEVEL, _levelData.level);
        else _levelData.level = 1;
        if (PlayerPrefs.HasKey(PLAYERPREFS_PROGRESSION)) _progressionData.playerProgression = PlayerPrefs.GetInt(PLAYERPREFS_PROGRESSION, _progressionData.playerProgression);
        else _progressionData.playerProgression = 1;

    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt(PLAYERPREFS_LEVEL, _levelData.level);
        PlayerPrefs.SetInt(PLAYERPREFS_XP, _levelData.playerXP);
        PlayerPrefs.SetInt(PLAYERPREFS_PROGRESSION, _progressionData.playerProgression);
    }

    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }
}
