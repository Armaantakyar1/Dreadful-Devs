using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPicker : MonoBehaviour
{
    [SerializeField] private float maxDistance = 2f;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] KeyCode pickup;

    [SerializeField] Transform objectToPickup;

    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance, layerMask))
        {
            if (hit.collider.CompareTag("Pickup"))
            {
                objectToPickup = hit.transform;
            }
        }
        else
        {
            objectToPickup = null;
        }
        if (Input.GetKeyDown(pickup) && objectToPickup != null)
        {

            objectToPickup.SetParent(transform);
            objectToPickup.localPosition = Vector3.zero;
            objectToPickup.GetComponent<Rigidbody>().isKinematic = true;
            objectToPickup = null;
        }
    }

}


