using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockScenes : MonoBehaviour
{
    [SerializeField] private GameObject _content;
    [SerializeField] private ProgressionData _progressionData;

    private void OnEnable()
    {
        UnlockScene();
    }

    private void UnlockScene()
    {
        if (_progressionData.playerProgression == 0)
        {
            return;
        }
        else if (_progressionData.playerProgression == 1)
        {
            Debug.Log("here");
            _content.transform.GetChild(1).GetChild(0).GetChild(1).gameObject.SetActive(false);
            _content.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            for (int i = 0; i < _progressionData.playerProgression + 1; i++)
            {
                _content.transform.GetChild(i).GetChild(0).GetChild(1).gameObject.SetActive(false);
                _content.transform.GetChild(i).GetChild(0).GetChild(0).gameObject.SetActive(true);
            }
        }

    }
}
