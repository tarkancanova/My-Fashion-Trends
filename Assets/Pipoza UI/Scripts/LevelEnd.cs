using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelEnd : MonoBehaviour
{
    public static LevelEnd Instance;
    public enum levelEndUI { WinUI, LoseUI };
    public enum UIType { Type1, Type1WithEmoji, Type2 };

    [Header(" UI Type : ")] [SerializeField] UIType uiType;

    [Header(" Animator : ")] [SerializeField] Animator levelEndAnimator;

    [Header(" Events : ")]
    [SerializeField] UnityEvent continueButtonFunction;
    [SerializeField] UnityEvent retryButtonFunction;
    

    void Awake() { if (Instance == null) Instance = this; }

    public void ShowUI(levelEndUI result)
    {
        string trigger = uiType.ToString() + " " + result.ToString();
        levelEndAnimator.SetTrigger(trigger);
    }

    public void HideUI() { levelEndAnimator.SetTrigger("Close UI"); }

    public void ContinueButton() { continueButtonFunction.Invoke(); }
    public void RetryButton() { retryButtonFunction.Invoke(); }  
}
