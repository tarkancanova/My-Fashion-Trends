using UnityEngine;

public class RVManager : MonoBehaviour
{
    private string reward;

    public static RVManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

    }

    public void CallRewarded(string Item)
    {
        reward = Item;
        SDKManager.Instance.RewardedVideo();
    }

    public void OnSuccess()
    {
        switch (reward)
        {
            case "Pose_4":
                PoseButtons.Instance.SetPoseIndex(3);
                break;
            case "Pose_5":
                PoseButtons.Instance.SetPoseIndex(4);
                break;
            case "Pose_6":
                PoseButtons.Instance.SetPoseIndex(5);
                break;
            case "Pose_7":
                PoseButtons.Instance.SetPoseIndex(6);
                break;
            default:
                Debug.Log("No Reward");
                break;
        }
    }
}
