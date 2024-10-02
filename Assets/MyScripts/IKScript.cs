using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKScript : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    // IK weight
    private float rightHandWeight = 0f;

    // Target for the hand
    public Transform rightHandTarget;

    private void OnAnimatorIK(int layerIndex)
    {
        // Set the right hand target position and weight
        if (rightHandWeight > 0)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandWeight);
            animator.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandWeight);
            animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandTarget.position);
            animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandTarget.rotation);
        }
    }

    public void SetRightHandTarget(Transform target)
    {
        rightHandTarget = target;
    }

    public void SetRightHandWeight(float weight)
    {
        rightHandWeight = weight;
    }
}
