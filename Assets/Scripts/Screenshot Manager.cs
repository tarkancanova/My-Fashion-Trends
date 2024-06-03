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
using UnityEngine.Networking;

public class ScreenshotManager : MonoBehaviour
{
    public RawImage displayImage; // UI RawImage element for displaying the screenshot
    public float delay = 0.5f; // Adjustable delay for screenshot saving

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
        yield return new WaitForSeconds(delay);

        if (File.Exists(filePath))
        {
            using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("file://" + filePath))
            {
                yield return uwr.SendWebRequest();

                if (uwr.result == UnityWebRequest.Result.Success)
                {
                    Texture2D texture = DownloadHandlerTexture.GetContent(uwr);

                    if (texture != null)
                    {
                        if (displayImage != null)
                        {
                            displayImage.texture = texture;
                            displayImage.gameObject.SetActive(true);
                            Debug.Log("Screenshot displayed: " + filePath);
                        }
                        else
                        {
                            Debug.LogError("displayImage is not assigned.");
                        }
                    }
                    else
                    {
                        Debug.LogError("Failed to create Texture2D from screenshot: " + filePath);
                    }
                }
                else
                {
                    Debug.LogError("Failed to load screenshot: " + filePath + ", Error: " + uwr.error);
                }
            }
        }
        else
        {
            Debug.LogError("Screenshot file not found: " + filePath);
        }
    }
}



