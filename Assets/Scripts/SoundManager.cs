using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    [SerializeField] private AudioSource _backgroundMusic;
    [SerializeField] private AudioSource _buttonEffect;
    [SerializeField] private AudioSource _dressingEffect;
    [SerializeField] private AudioSource _cameraEffect;

    private int _sound;
    private int _music;

    private void Start()
    {
        _sound = PlayerPrefs.GetInt("Sound");
        _music = PlayerPrefs.GetInt("Music");

        if (_sound == 1)
        {
            MuteAllSounds();
        }

        if (_music == 0)
            _backgroundMusic.Play();
        else MuteAllMusic();
    }

    public void PlayButtonEffect()
    {
        _buttonEffect.Play();
    }

    public void PlayDressingEffect()
    {
        _dressingEffect.Play();
    }

    public void PlayCameraEffect()
    {
        _cameraEffect.Play();
    }

    public void MuteAllSounds()
    {
        _buttonEffect.mute = true;
        _dressingEffect.mute = true;
        _cameraEffect.mute = true;
    }

    public void UnmuteAllSounds()
    {
        _buttonEffect.mute = false;
        _dressingEffect.mute = false;
        _cameraEffect.mute = false;
    }

    public void MuteAllMusic()
    {
        _backgroundMusic.mute = true;
    }

    public void UnmuteMusic()
    {
        _backgroundMusic.mute = false;
        _backgroundMusic.Play();
    }
}
