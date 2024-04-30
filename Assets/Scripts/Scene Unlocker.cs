using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneUnlocker : MonoBehaviour
{
    [SerializeField] private ProgressionData _progressionData;


    public void UnlockScene()
    {
        if (!_progressionData.sceneTwoUnlocked)
            _progressionData.sceneTwoUnlocked = true;
        else
            _progressionData.sceneThreeUnlocked = true;
    }
}
