using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPicker : MonoBehaviour
{
    [SerializeField] Camera cam1;
    private GameObject pickedUpObject;
    [SerializeField] KeyCode pickup;
    [SerializeField] KeyCode drop;

    void Update()
    {
        if (Input.GetKeyDown(pickup))
        {

            Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1f);
            foreach (Collider hitCollider in hitColliders)
            {
                if (hitCollider.CompareTag("Pickup"))
                {
               
                    pickedUpObject = hitCollider.gameObject;
                    pickedUpObject.transform.SetParent(transform);
                    
                    pickedUpObject.GetComponent<Rigidbody>().isKinematic = true;
                    
                }
            }
        }
        if (Input.GetKeyDown(drop))
        {
            if (pickedUpObject != null)
            {
          
                pickedUpObject.transform.SetParent(null);
                pickedUpObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedUpObject = null;
            }
        }
    }
}


