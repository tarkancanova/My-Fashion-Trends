using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageScreen : MonoBehaviour
{
    [SerializeField] private GameObject _messages;
    [SerializeField] private GameObject _messageScene;
    [SerializeField] private GameObject _inGameUI;

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
            yield return new WaitForSeconds(1f);
        }
    }

    public void NextButton()
    {
        _messageScene.SetActive(false);
        _inGameUI.SetActive(true);
    }

}
