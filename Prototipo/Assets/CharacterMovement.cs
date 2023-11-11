using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 5.0f;
    public float jumpSpeed = 5.0f;
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVel;

    private Vector3 jumpForce = Vector3.zero;
    public float gravity = 10f;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get axis horizontal and vertical
        float H_axis = Input.GetAxis("Horizontal");
        float V_axis = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(H_axis, 0, V_axis).normalized;

        if(dir.magnitude >= 0.1f)
        {
            float angle = (Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg) + cam.transform.eulerAngles.y;
            float angle2 = Mathf.SmoothDampAngle(transform.eulerAngles.y,angle,ref turnSmoothVel, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f,angle2,0f);

            var dir2 = Quaternion.Euler(0f, angle, 0f) * Vector3.forward;
            characterController.Move(dir * speed * Time.deltaTime);
        }

        jumpForce.y -= gravity * Time.deltaTime; 

        bool jumpBtn = Input.GetButtonDown("Jump");
        if(jumpBtn)
        {
            jumpForce.y = jumpSpeed * Time.deltaTime;
            
        }

        characterController.Move(jumpForce * Time.deltaTime);
    }
}
