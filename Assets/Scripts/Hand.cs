using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Hand : MonoBehaviour
{
    public float speed;
    SkinnedMeshRenderer mesh;
    string animatorGripParam = "Grip";
    string animatorTriggerParam = "Trigger";
    Animator animator;
    private float triggerTarget;
    private float gripTarget; 
    private float triggerCurrent;
    private float gripCurrent;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void AnimateHand()
    {
        if (gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorGripParam, gripCurrent);
        }
        if (triggerCurrent != triggerTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorTriggerParam, triggerCurrent);
        }


    }

    public void ToggleVisibility()
    {
        mesh.enabled = !mesh.enabled;
    }
}
