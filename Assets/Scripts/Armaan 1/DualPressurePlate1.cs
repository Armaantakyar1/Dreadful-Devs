using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualPressurePlate1 : MonoBehaviour
{
    [SerializeField]PlatesManager manager;
    [SerializeField]bool once;
    private void OnTriggerEnter(Collider other)
    {
        if (once == false)
        {
            manager.Activated();
            once = true;
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (once == false)
        {
            manager.Activated();
            once = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (once == true)
        {
            manager.Deactivated();
            once = false;
        }
        
    }
}
