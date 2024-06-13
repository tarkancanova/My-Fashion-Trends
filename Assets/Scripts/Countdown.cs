using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public Button startButton;
    [SerializeField] ScreenshotManager _screenshotManager;
    [SerializeField] DisableUI _disableUI;
    [SerializeField] public PoseToZero _poseToZero;
    public float animationDuration = 0.5f;

    private Vector3 originalScale;

    private void Start()
    {
        startButton.onClick.AddListener(StartCountdown);
        countdownDisplay.text = "";
        originalScale = countdownDisplay.transform.localScale;
    }

    void StartCountdown()
    {
        StartCoroutine(CountdownToStart());
        startButton.interactable = false;
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return StartCoroutine(AnimateText());
            countdownTime--;
        }

        countdownDisplay.text = "Go!";
        yield return StartCoroutine(AnimateText());

        yield return new WaitForSeconds(.5f);

        if (countdownTime == 0)
        {
            _screenshotManager.TakeScreenshot();
            _disableUI.OnContinueButtonClick();
            _poseToZero.SetPoseIndexInAnimatorToZero();
        }

        countdownDisplay.gameObject.SetActive(false);
    }

    IEnumerator AnimateText()
    {
        float elapsedTime = 0f;


        while (elapsedTime < animationDuration)
        {
            countdownDisplay.transform.localScale = Vector3.Lerp(originalScale, originalScale * 2f, elapsedTime / animationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        countdownDisplay.transform.localScale = originalScale * 2f;

        elapsedTime = 0f;


        while (elapsedTime < animationDuration)
        {
            countdownDisplay.transform.localScale = Vector3.Lerp(originalScale * 2f, originalScale, elapsedTime / animationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        countdownDisplay.transform.localScale = originalScale;
    }
}