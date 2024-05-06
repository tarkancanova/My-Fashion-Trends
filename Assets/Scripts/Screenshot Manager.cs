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

using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;

public class ScreenshotManager : MonoBehaviour
{
    public RawImage displayImage; // UI RawImage element for displaying the screenshot

    public void TakeScreenshot()
    {
        string screenshotFilename = "Screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";
        string filePath = Path.Combine(Application.persistentDataPath, screenshotFilename);

        ScreenCapture.CaptureScreenshot(filePath);

        StartCoroutine(LoadScreenshot(filePath));
    }

    IEnumerator LoadScreenshot(string filePath)
    {

        // Wait for the screenshot to be saved
        yield return new WaitForSeconds(0.5f);

        if (File.Exists(filePath))
        {
            byte[] byteArray = File.ReadAllBytes(filePath);
            Texture2D texture = new Texture2D(2, 2);
            bool isLoaded = texture.LoadImage(byteArray);

            if (isLoaded)
            {
                displayImage.texture = texture;
                displayImage.gameObject.SetActive(true);
                Debug.Log("Screenshot displayed: " + filePath);
            }
            else
            {
                Debug.Log("Failed to load screenshot: " + filePath);
            }
        }
        else
        {
            Debug.Log("Screenshot file not found: " + filePath);
        }

    }
}



