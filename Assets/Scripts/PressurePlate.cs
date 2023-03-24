using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] GameObject toManiplate;

    private void OnTriggerEnter(Collider other)
    {
        toManiplate.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        toManiplate.SetActive(false);
    }

}
