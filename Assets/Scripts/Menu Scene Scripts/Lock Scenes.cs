using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScenes : MonoBehaviour
{
    [SerializeField] private GameObject _sceneTwoButton;
    [SerializeField] private GameObject _sceneTwoLocked;
    [SerializeField] private GameObject _sceneThreeButton;
    [SerializeField] private GameObject _sceneThreeLocked;
    [SerializeField] private ProgressionData _progressionData;


    private void Start()
    {
        if (!_progressionData.sceneTwoUnlocked)
        {
            _sceneTwoButton.SetActive(false);
            _sceneTwoLocked.SetActive(true);
            _sceneThreeButton.SetActive(false);
            _sceneThreeLocked.SetActive(true);
        }        
        else if (_progressionData.sceneTwoUnlocked && !_progressionData.sceneThreeUnlocked)
        {
            _sceneTwoButton.SetActive(true);
            _sceneTwoLocked.SetActive(false);
            _sceneThreeButton.SetActive(false);
            _sceneThreeLocked.SetActive(true);
        }        
        else if (_progressionData.sceneTwoUnlocked && _progressionData.sceneThreeUnlocked)
        {
            _sceneTwoButton.SetActive(true);
            _sceneTwoLocked.SetActive(false);
            _sceneThreeButton.SetActive(true);
            _sceneThreeLocked.SetActive(false);
        }
    }

}
