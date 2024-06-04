using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private GameObject _backgroundSelectionUI;
    [SerializeField] private GameObject _backgroundsObject;
    [SerializeField] private GameObject _inGameUI;
    [SerializeField] private ProgressionData _progData;

    private void Start()
    {

        for (int i = 0; i < this.transform.childCount; i++)
        {
            GameObject child = this.transform.GetChild(i).gameObject;
            Button button = child.GetComponent<Button>();

            if (button != null)
            {
                int capturedIndex = i;
                button.onClick.AddListener(() => OnClickButton(capturedIndex));
            }
        }

    }

    private void OnClickButton(int backgroundIndex)
    {

        if (_progData.playerProgression < backgroundIndex) return;


        _backgroundSelectionUI.SetActive(false);

        for (int i = 0; i < _backgroundsObject.transform.childCount; i++)
        {
            _backgroundsObject.transform.GetChild(i).gameObject.SetActive(false);
        }

        if (backgroundIndex >= 0 && backgroundIndex < _backgroundsObject.transform.childCount)
        {
            _backgroundsObject.transform.GetChild(backgroundIndex).gameObject.SetActive(true);
        }


        _inGameUI.SetActive(true);

    }
}
