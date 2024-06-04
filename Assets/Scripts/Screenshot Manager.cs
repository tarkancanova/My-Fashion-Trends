//using UnityEngine;

//public class ScreenshotManager : MonoBehaviour
//{
//    public void TakeScreenshot()
//    {
//        string screenshotFilename = "Screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";

//        ScreenCapture.CaptureScreenshot(Application.persistentDataPath + "/" + screenshotFilename);

//        Debug.Log("Screenshot saved: " + screenshotFilename);
//    }
//}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScreenshotManager : MonoBehaviour
{
    public RawImage displayImage; // UI RawImage element for displaying the screenshot
    public float delay = 0.5f; // Adjustable delay for screenshot capturing

    public void TakeScreenshot()
    {
        StartCoroutine(CaptureScreenshot());
    }

    IEnumerator CaptureScreenshot()
    {
        yield return new WaitForEndOfFrame();

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



