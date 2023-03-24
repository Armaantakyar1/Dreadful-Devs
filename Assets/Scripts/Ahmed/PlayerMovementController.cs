using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] Transform playerHead;

    [SerializeField] float moveSpeed;
    [SerializeField] float lookSensetivey;

    [SerializeField] string horizontal;
    [SerializeField] string vertical;

    CharacterController charCon;

    Vector2 stickInput;
    float verticalRotStore;

    private void Awake()
    {
        charCon= GetComponent<CharacterController>();
    }

    private void Update()
    {
        RotationControll();
        MoveControll();
    }



    void RotationControll()
    {
        stickInput.x = Input.GetAxis(horizontal);
        stickInput.y = Input.GetAxis(vertical);

        transform.Rotate(Vector3.up, stickInput.x * lookSensetivey);


        float verticalRotation = stickInput.y * lookSensetivey;
        verticalRotStore += verticalRotation;
        verticalRotStore = Mathf.Clamp(verticalRotStore, -50f, 60f);
        playerHead.transform.localRotation = Quaternion.Euler(-verticalRotStore, 0f, 0f);

       // playerHead.transform.Rotate(Vector3.right,  stickInput.y * lookSensetivey);
        
    }
    void MoveControll()
    {

    }

}
