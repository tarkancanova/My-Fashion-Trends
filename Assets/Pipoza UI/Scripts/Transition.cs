using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public static Transition Instance;

    public enum transitions { Basic, Colored };

    [Header(" Animation Type : ")] [SerializeField] transitions transitionType;
    [Header(" Animator : ")] [SerializeField] Animator transitionAnimator;

    void Awake() { if (Instance == null) Instance = this; }

    public void TransitionAnim() { transitionAnimator.SetTrigger(transitionType.ToString()); }
}
