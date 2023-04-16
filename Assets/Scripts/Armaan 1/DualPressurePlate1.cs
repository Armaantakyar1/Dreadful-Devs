using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualPressurePlate1 : MonoBehaviour
{
    PlatesManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<PlatesManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        manager.Activated();
    }
    
    private void OnTriggerExit(Collider other)
    {
        manager.Deactivated();
    }
}
