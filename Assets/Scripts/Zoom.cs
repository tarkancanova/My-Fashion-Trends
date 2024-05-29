using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] private Camera _zoomedCamera;
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private GameObject _makeupMenu;

    private void Update()
    {
        ChangeCameras();
    }

    private void ChangeCameras()
    {
        if (_makeupMenu.activeSelf)
        {
            _zoomedCamera.gameObject.SetActive(true);
            _mainCamera.gameObject.SetActive(false);
        }
        else if (!_makeupMenu.activeSelf)
        {
            _mainCamera.gameObject.SetActive(true);
            _zoomedCamera.gameObject.SetActive(false);
        }
    }
}
