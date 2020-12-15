using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    float velocity = 0.0f;
    public float acceleration = 0.1f;
    public float deceleration = 0.5f;
    int VelocityHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        VelocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {
     
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if ( velocity < 1.0f && forwardPressed)//if w pressed
        {
            velocity += Time.deltaTime * acceleration;
        }

        if ( velocity > 0.0f && !forwardPressed)// if w not pressed
        {
            velocity -= Time.deltaTime * deceleration;
        }

        if ( !forwardPressed && velocity < 0.0f)// if player stop run or walk
        {
            velocity = 0.0f; 
        }
        animator.SetFloat(VelocityHash, velocity);
    }
}
