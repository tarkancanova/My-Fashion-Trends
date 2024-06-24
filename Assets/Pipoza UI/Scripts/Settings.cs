using UnityEngine;

public class Settings : MonoBehaviour
{
    public static Settings Instance;

    [SerializeField] Animator settingsAnimator;
    [SerializeField] GameObject soundOffImg, vibrationOffImg;
    int sound, vibration;
    bool settingsOpened;

    void Awake()
    {
        if (Instance == null) Instance = this;

        sound = PlayerPrefs.GetInt("Sound");
        vibration = PlayerPrefs.GetInt("Music");

        soundOffImg.SetActive(!SoundOn());
        vibrationOffImg.SetActive(!VibrationOn());
    }

    public void SoundButton()
    {
        if (sound == 0) sound = 1;
        else sound = 0;

        PlayerPrefs.SetInt("Sound", sound);
        soundOffImg.SetActive(!SoundOn());

        if (sound == 1)
        {
            SoundManager.Instance.MuteAllSounds();
        }
        else
        {
            SoundManager.Instance.UnmuteAllSounds();
        }
    }

    public void MusicButton()
    {
        if (vibration == 0) vibration = 1;
        else vibration = 0;

        PlayerPrefs.SetInt("Music", vibration);
        vibrationOffImg.SetActive(!VibrationOn());

        if (vibration == 1)
        {
            SoundManager.Instance.MuteAllMusic();
        }
        else
        {
            SoundManager.Instance.UnmuteMusic();
        }
    }

    public void SettingsButton()
    {
        if (!settingsOpened)
        {
            settingsOpened = true;
            settingsAnimator.SetTrigger("Open");
        }
        else
        {
            settingsOpened = false;
            settingsAnimator.SetTrigger("Close");
        }
    }

    public bool SoundOn()
    {
        if (sound == 0) return true;
        else return false;
    }

    public bool VibrationOn()
    {
        if (vibration == 0) return true;
        else return false;
    }
}
