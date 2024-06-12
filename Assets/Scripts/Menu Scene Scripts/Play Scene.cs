using UnityEngine;

public class PlayScene : MonoBehaviour
{
    [SerializeField] private GameObject _playScene;
    [SerializeField] private GameObject _backgroundSelectionScene;
    //[SerializeField] private GameObject _messageScreens;
    //[SerializeField] private GameObject _backgroundsObject;


    public void OnPlayButtonClick()
    {
        if (!PlayerPrefs.HasKey("Background"))
        {
            Debug.Log(PlayerPrefs.HasKey("Background"));
            _playScene.SetActive(false);
            _backgroundSelectionScene.SetActive(true);
        }
        else
        {
            Debug.Log(PlayerPrefs.HasKey("Background"));
            _playScene.SetActive(false);
            _backgroundSelectionScene.SetActive(true);
            //_messageScreens.transform.GetChild(PlayerPrefs.GetInt("Background")).gameObject.SetActive(true);
            //_backgroundsObject.transform.GetChild(PlayerPrefs.GetInt("Background")).gameObject.SetActive(true);
        }


    }
}
