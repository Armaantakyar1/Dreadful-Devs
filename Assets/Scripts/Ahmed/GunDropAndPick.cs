using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunDropAndPick : MonoBehaviour
{
    [SerializeField] Transform gunHoldPoint;
    [SerializeField] Transform gun;
    [SerializeField] Rigidbody gunBody;
    [SerializeField] Collider gunCollider;

    float distanceBetweenGun;
    bool pickedUp;

   

    void DistanceFromGun()
    {
        distanceBetweenGun = Vector3.Distance(transform.position, gun.position);
    }
    private void Update()
    {
        DistanceFromGun();

        if (!pickedUp && distanceBetweenGun < 4 && Input.GetKeyDown(KeyCode.JoystickButton3)) 
        {
            gunBody.isKinematic = true;
            gunBody.useGravity = false;
            gunCollider.enabled = false;
            gunHoldPoint.position = gun.position;
            gunHoldPoint.parent = gun;
            pickedUp = true;
        }
        if(pickedUp && Input.GetKeyDown(KeyCode.JoystickButton3)) 
        { 
            gunHoldPoint.parent = null;
            gunBody.isKinematic = false;
            gunBody.useGravity = true;
            gunCollider.enabled = true;
            pickedUp = false;
        }
    }
}
