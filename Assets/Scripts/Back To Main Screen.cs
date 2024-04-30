using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainScreen : MonoBehaviour
{
    public void ReloadMainScreen()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}
