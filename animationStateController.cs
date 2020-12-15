using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isrunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (!isWalking && forwardPressed)//if w pressed
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !forwardPressed)// if w not pressed
        {
            animator.SetBool(isWalkingHash, false);
        }

        if(!isrunning && !(!forwardPressed || !runPressed))// if player walk and pressed left shift
        {
            animator.SetBool(isRunningHash, true);
        }

        if(isrunning && (!forwardPressed || !runPressed))// if player stop run or walk
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
