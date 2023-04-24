using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPicker : MonoBehaviour
{
    [SerializeField] private float maxDistance = 2f;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] KeyCode pickup;
    [SerializeField] KeyCode drop;
    [SerializeField] Transform point;
    [SerializeField] Transform objectToPickup;
    [SerializeField] int childPosition;
    
    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance, layerMask))
        {
            if (hit.collider.CompareTag("Object") || hit.collider.CompareTag("Object2"))
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
            objectToPickup.transform.position = point.position;
            objectToPickup.GetComponent<Rigidbody>().isKinematic = true;
            
        }
        
        if (Input.GetKeyDown(drop))
        {
            
            Transform carriedObject = transform.GetChild(childPosition);
            if (carriedObject != null)
            {
                
                carriedObject.SetParent(null);
                carriedObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }

    }
}


