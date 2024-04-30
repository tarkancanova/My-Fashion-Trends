using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueButtons : MonoBehaviour
{

    [SerializeField] private GameObject _characterUI;
    [SerializeField] private GameObject _backgroundUI;


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
        if (gameObject.transform.CompareTag("BackgroundContinue"))
        {
            SceneManager.LoadScene("Game Scene");
        }
        else if (gameObject.transform.CompareTag("CharacterContinue"))
        {
            _characterUI.SetActive(false);
            _backgroundUI.SetActive(true);
        }
    }

}
