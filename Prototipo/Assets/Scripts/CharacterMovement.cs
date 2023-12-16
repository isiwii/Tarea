using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;

    public float jumpSpeed = 5.0f;
    public float gravity = 10.0f;
    private float verticalVelocity = 0.0f;

    public float coyoteTime = 0.2f;
    private float coyoteCurrent = 0;

    public CharacterController controller;
    public Transform cam;
    public Animator animator;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        var H_axis = Input.GetAxis("Horizontal");
        var V_axis = Input.GetAxis("Vertical");
        var dir = new Vector3(H_axis, 0, V_axis).normalized;

        var jump = Input.GetButtonDown("Jump");

        if (controller.isGrounded)
            coyoteCurrent = 0;
        else
            coyoteCurrent += Time.deltaTime;

        if ((controller.isGrounded || coyoteCurrent <= coyoteTime) && jump)
        {
            verticalVelocity = jumpSpeed;
            animator.SetTrigger("Jumping");
        }

        verticalVelocity -= gravity * Time.deltaTime;
        var jumpVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(jumpVector * Time.deltaTime);

        if (dir.magnitude >= 0.1f)
        {
            animator.SetBool("isWalking", true);

            var targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            var angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            var moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir * speed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey("x"))
        {
            speed = 10.0f;
        }
        else
        {
            speed = 5.0f;
        }
    }
}
