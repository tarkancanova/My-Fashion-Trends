using CrazyGames;
using UnityEngine;

public class SDKManager : MonoBehaviour
{
    public static SDKManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        CrazySDK.Init(() => { InitializationCompleted(); });

    }

    private void InitializationCompleted()
    {
        Debug.Log("SDK Initialized");
    }

    public void RewardedVideo()
    {
        CrazySDK.Ad.RequestAd(CrazyAdType.Rewarded, () =>
        {
            Debug.Log("Rewarded Started");
            /* ad started */
        }, (error) =>
        {
            Debug.Log("Rewarded Failed");
            /* ad error */
        }, () =>
        {
            Debug.Log("Rewarded Ended");
            RVManager.Instance.OnSuccess(); /* giving reward */
        });
    }

    public void MidGameVideo()
    {
        CrazySDK.Ad.RequestAd(CrazyAdType.Midgame, () =>
        {
            Debug.Log("Interstitial Started");
            /* ad started */
        }, (error) =>
        {
            Debug.Log("Interstitial Failed");
            /* ad error */
        }, () =>
        {
            Debug.Log("Interstitial Ended");
            /* ad ended */
        });
    }   

    public void SetGameStatus(bool bIsGameStarted)
    {
        if (bIsGameStarted)
        {
            CrazySDK.Game.GameplayStart();
        }
        else
        {
            CrazySDK.Game.GameplayStop();
        }
    }
}