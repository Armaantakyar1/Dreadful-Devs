using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] Transform playerUpperbody;
    [SerializeField] Transform camViewPoint;
    [SerializeField] Animator animator;

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] float lookSensetivey;
    float yStore;

    [Header("Joystick Mapping")]

    [SerializeField] string rightStickHorizontal;
    [SerializeField] string rightStickVertical;

    [SerializeField] string leftStickHorizontal;
    [SerializeField] string leftStickVertical;
    [SerializeField] KeyCode jump;

    CharacterController charCon;
    public Vector3 direction = Vector3.zero;

    Vector2 rightStickInput;
    public Vector3 movementDirection;

    public Transform platform;
    float verticalRotStore;
    public Vector3 velocity=Vector3.zero;

    private void Awake()
    {
        charCon= GetComponent<CharacterController>();
    }

    private void Update()
    {
        RotationControll();
        MoveControll();
        Jump();
        PlayerAnimation();
    }

    private void FixedUpdate()
    {
        movementDirection.y = velocity.y + (Physics.gravity.y * Time.fixedDeltaTime);
        velocity.y += Physics.gravity.y * Time.fixedDeltaTime;
        if (charCon.isGrounded&& velocity.y<0)
        {
            velocity.y = 0;
        }
    }

    void RotationControll()
    {
        rightStickInput.x = Input.GetAxisRaw(rightStickHorizontal);
        rightStickInput.y = Input.GetAxisRaw(rightStickVertical);

        transform.Rotate(Vector3.up, rightStickInput.x * lookSensetivey);


        float verticalRotation = rightStickInput.y * lookSensetivey;
        verticalRotStore += verticalRotation;
        verticalRotStore = Mathf.Clamp(verticalRotStore, -50f, 100f);
        playerUpperbody.transform.localRotation = Quaternion.Euler(verticalRotStore, 0f, 0f);
        camViewPoint.transform.localRotation = Quaternion.Euler(verticalRotStore, 0f, 0f);
    }
    public void ZeroDirection()
    {
        direction = Vector3.zero;
    }
    void MoveControll()
    {
        yStore = movementDirection.y;
        float horizontalInput = Input.GetAxisRaw(leftStickHorizontal);
        float verticalInput = Input.GetAxisRaw(leftStickVertical);

        Vector3 forwardDirection = transform.forward;
        forwardDirection.y = 0f;
        movementDirection = (horizontalInput * transform.right + verticalInput * forwardDirection).normalized;

        movementDirection.y = yStore;
        charCon.Move((movementDirection * moveSpeed +direction)*Time.deltaTime);
    }
    void Jump()
    {
        if(charCon.isGrounded)
        {
            if(Input.GetKeyDown(jump))
            {
                velocity.y = jumpForce;
                
            }
        }
    }
    void PlayerAnimation()
    {
        if (movementDirection.z > 0)
        {
            animator.SetBool("isMovingBackward", false);
            animator.SetBool("isMovingForward", true);
        }
        else if (movementDirection.z < 0)
        {
            animator.SetBool("isMovingBackward", true);
            animator.SetBool("isMovingForward", false);
        }
        else
        {
            animator.SetBool("isMovingBackward", false);
            animator.SetBool("isMovingForward", false);
        }
    }

}
