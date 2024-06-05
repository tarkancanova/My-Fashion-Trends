using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HorizontalSnapScrollRect : MonoBehaviour
{
    public ScrollRect scrollRect;
    public RectTransform contentPanel;
    public List<float> targetPositions;
    public float smoothTime = 0.3f; 

    private int currentIndex = 0;
    private bool isSnapping = false;
    private Vector2 velocity = Vector2.zero;

    private void Update()
    {

        if (isSnapping)
        {
            Vector2 targetPosition = new Vector2(targetPositions[currentIndex], contentPanel.anchoredPosition.y);
            contentPanel.anchoredPosition = Vector2.SmoothDamp(contentPanel.anchoredPosition, targetPosition, ref velocity, smoothTime);

            if (Vector2.Distance(contentPanel.anchoredPosition, targetPosition) < 0.01f)
            {
                isSnapping = false;
            }
        }
    }

    public void SnapToNextPosition()
    {
        if (targetPositions.Count == 0)
        {
            Debug.LogWarning("No target positions set.");
            return;
        }

        currentIndex = (currentIndex + 1) % targetPositions.Count;
        isSnapping = true;
    }

    public void SnapToPreviousPosition()
    {
        if (targetPositions.Count == 0)
        {
            Debug.LogWarning("No target positions set.");
            return;
        }

        if (currentIndex > 0)
        {
            currentIndex = (currentIndex - 1) % targetPositions.Count;
        }
        else
            currentIndex = targetPositions.Count - 1;
        isSnapping = true;
    }
}
