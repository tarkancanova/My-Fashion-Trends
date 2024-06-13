using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoseButtons : MonoBehaviour
{
    private Button _button;
    [SerializeField] private int poseIndex;
    [SerializeField] public Animator _animator;


    private void OnEnable()
    {
        _button = GetComponent<Button>();
        if (_button != null)
        {
            _button.onClick.AddListener(OnClickButton);
        }
    }

    private void Update()
    {
        Debug.Log(_animator.GetInteger("Pose"));
    }

    private void OnDisable()
    {
        if (_button != null)
        {
            _button.onClick.RemoveListener(OnClickButton);
        }
    }

    public void OnClickButton()
    {
        //PoseZero.SetPoseIndexInAnimatorToZero();
        _animator.SetInteger("Pose", poseIndex);
    }

    //public void SetPoseIndexInAnimatorToZero()
    //{
    //   _animator.SetInteger("Pose", 0);
    //}
}
