using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseToZero : PoseButtons
{
    public void SetPoseIndexInAnimatorToZero()
    {
        _animator.SetInteger("Pose", 0);
    }
}
