using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKctrl : MonoBehaviour
{
    Animator anim;

    public Transform controllerIk;
    [Range(0,1)]
    public float weight;

    public Transform controllerHint;
    [Range(0, 1)]
    public float weightHint;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnAnimatorIK()
    {
        if (anim)
        {
            anim.SetIKPositionWeight(AvatarIKGoal.RightHand, weight);
            anim.SetIKPosition(AvatarIKGoal.RightHand, controllerIk.position);
            anim.SetIKRotationWeight(AvatarIKGoal.RightHand, weight);
            anim.SetIKRotation(AvatarIKGoal.RightHand, controllerIk.rotation);

            anim.SetIKHintPositionWeight(AvatarIKHint.RightElbow, weightHint);
            anim.SetIKHintPosition(AvatarIKHint.RightElbow, controllerHint.position);
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
