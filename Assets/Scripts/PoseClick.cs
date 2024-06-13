using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseClick : MonoBehaviour
{
    public void SetPose(int poseIndex)
    {
        PoseButtons.Instance.SetPoseIndex(poseIndex);
    }
}
