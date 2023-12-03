using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float specialSpeed = 10.0f;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      // bool isJumping = animator.GetBool("isJumping");
      // bool jumpPressed = Input.GetKey("z");

       if (Input.GetKey("space"))
       {
        animator.SetBool("isJumping", true);
       }

       if (!Input.GetKey("space"))
       {
            animator.SetBool("isJumping", false);
       }

       

       if (Input.GetKey("x"))
       {
        animator.SetBool("isRunning", true);

       }

       if (!Input.GetKey("x"))
       {
            animator.SetBool("isRunning", false);
       }
    }
}
