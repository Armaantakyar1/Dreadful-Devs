using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPicker : MonoBehaviour
{

    private GameObject pickedUpObject;
    [SerializeField] KeyCode pickup;

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
                    pickedUpObject.transform.localPosition = new Vector3(0f, 0.5f, 0f);
                    pickedUpObject.GetComponent<Rigidbody>().isKinematic = true;
                    
                }
            }
        }

     
        if (Input.GetKeyDown(pickup))
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


