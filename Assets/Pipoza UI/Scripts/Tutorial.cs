using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tutorial : MonoBehaviour
{
    public static Tutorial Instance;

    public enum TutorialType { TapToPlay, SwipeToPlay1, SwipeToPlay2, DragToPlay };
    [SerializeField] TutorialType tutorial;
    [SerializeField] Animator animator;
    [SerializeField] GameObject[] tutorials;
    bool tutorialActivate;

    [SerializeField] GameObject holdHandAnimation;

    void Awake()
    {
        if(Instance == null) Instance = this;
        tutorials[(int)tutorial].SetActive(true);
        tutorialActivate = true;
    }

    void Start()
    {
        Invoke("CloseHoldHandAnimation", 5);
    }

    void CloseHoldHandAnimation()
    {
        holdHandAnimation.SetActive(false);
    }

    public void ShowTutorial()
    { 
        if(tutorialActivate) return;
        animator.SetTrigger("Idle"); 
        tutorialActivate = true;
        transform.localScale = Vector3.zero;
        transform.DOScale(Vector3.one, 0.4f).SetEase(Ease.OutBack);
    }
    public void HideTutorial()
    { 
        if(!tutorialActivate) return;
        animator.SetTrigger("Hide"); 
        tutorialActivate = false;
    }
}
