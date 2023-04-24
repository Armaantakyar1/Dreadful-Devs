using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualPressurePlate1 : MonoBehaviour
{
    [SerializeField]PlatesManager manager;
    [SerializeField]bool once;
    [SerializeField] string tag1;
    [SerializeField] string tag2;
    [SerializeField] string tag3;

    [SerializeField] string tag4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tag1) || other.CompareTag(tag2) || other.CompareTag(tag3) || other.CompareTag(tag4))
        {
            if (once == false)
            {
                manager.Activated();
                once = true;
            }
        }
            
        
        
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(tag1) || other.CompareTag(tag2) || other.CompareTag(tag3) || other.CompareTag(tag4))
        {

            if (once == false)
            {
                manager.Activated();
                once = true;
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {

        if(other.CompareTag(tag1) || other.CompareTag(tag2) || other.CompareTag(tag3) || other.CompareTag(tag4))
        {
            if (once == true)
            {
                manager.Activated();
                once = false;
            }
        }

    }
}
