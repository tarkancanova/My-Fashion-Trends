using UnityEngine;

public class SaveData : Singleton<SaveData>
{
    [SerializeField] public ProgressionData _progressionData;
    [SerializeField] public LevelData _levelData;
    [SerializeField] public BackgroundManager _backgroundManager;
    private const string PLAYERPREFS_LEVEL = "Level";
    private const string PLAYERPREFS_XP = "XP";
    private const string PLAYERPREFS_PROGRESSION = "Progression";
    private const string BACKGROUND_SELECTION = "Background";

    //In OnEnable, sets the data from playerprefs to scriptableobject. In OnDisable, sets the data from scriptableobject to playerprefs.

    private void Start()
    {
        if (PlayerPrefs.HasKey(PLAYERPREFS_XP)) _levelData.playerXP = PlayerPrefs.GetInt(PLAYERPREFS_XP, _levelData.playerXP);
        else _levelData.playerXP = 0;
        if (PlayerPrefs.HasKey(PLAYERPREFS_LEVEL)) _levelData.level = PlayerPrefs.GetInt(PLAYERPREFS_LEVEL, _levelData.level);
        else _levelData.level = 1;
        if (PlayerPrefs.HasKey(PLAYERPREFS_PROGRESSION)) _progressionData.playerProgression = PlayerPrefs.GetInt(PLAYERPREFS_PROGRESSION, _progressionData.playerProgression);
        else _progressionData.playerProgression = 0;
    }

    public void Save()
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
