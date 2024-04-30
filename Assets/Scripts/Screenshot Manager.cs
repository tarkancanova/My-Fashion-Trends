using UnityEngine;

public class ScreenshotManager : MonoBehaviour
{
    public void TakeScreenshot()
    {
        string screenshotFilename = "Screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";

        ScreenCapture.CaptureScreenshot(Application.persistentDataPath + "/" + screenshotFilename);

        Debug.Log("Screenshot saved: " + screenshotFilename);
    }
}

