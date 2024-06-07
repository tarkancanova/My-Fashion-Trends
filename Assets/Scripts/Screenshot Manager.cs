using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScreenshotManager : MonoBehaviour
{
    public RawImage displayImage; // UI RawImage element for displaying the screenshot
    public float delay = 0.5f; // Adjustable delay for screenshot capturing
    [SerializeField] private GameObject _flashEffect;

    public void TakeScreenshot()
    {
        StartCoroutine(CaptureScreenshot());
    }

    IEnumerator CaptureScreenshot() //Takes the screenshot and displays it.
    {
        yield return new WaitForEndOfFrame();

        _flashEffect.GetComponent<ParticleSystem>().Play();

        // Create a Texture2D with screen width and height
        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        // Read the screen contents into the texture
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();

        // Assign the texture to the RawImage component
        if (displayImage != null)
        {
            displayImage.texture = texture;
            displayImage.gameObject.SetActive(true);
            Debug.Log("Screenshot displayed.");
        }
        else
        {
            Debug.LogError("displayImage is not assigned.");
        }
    }
}



