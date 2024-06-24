using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MessageScreen : MonoBehaviour
{
    [SerializeField] private GameObject _messages;
    [SerializeField] private GameObject _messageScene;
    [SerializeField] private GameObject _inGameUI;
    [SerializeField] private GameObject _nextButton;
    [SerializeField] private GameObject _phone;

    // Start is called before the first frame update
    private void OnEnable()
    {
        StartCoroutine(Phone());
    }

    private IEnumerator Phone()
    {
        for (int i = 0; i < _messages.transform.childCount; i++)
        {
            _messages.transform.GetChild(i).gameObject.SetActive(true);
            VibratePhone();
            yield return new WaitForSeconds(1f);
        }

        _nextButton.gameObject.SetActive(true);
    }

    public void NextButton()
    {
        _messageScene.SetActive(false);
        _inGameUI.SetActive(true);
        SoundManager.Instance.PlayButtonEffect(); // SFX
    }
    private void VibratePhone()
    {
        // Shake the phone GameObject
        _phone.transform.DOShakePosition(0.5f, 10, 20, 90, false, true);
    }


}
