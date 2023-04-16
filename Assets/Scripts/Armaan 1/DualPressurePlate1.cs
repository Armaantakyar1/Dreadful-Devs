using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualPressurePlate1 : MonoBehaviour
{
    [SerializeField]PlatesManager manager;
    private void OnTriggerEnter(Collider other)
    {
        manager.Activated();
    }
    
    private void OnTriggerExit(Collider other)
    {
        manager.Deactivated();
    }
}
