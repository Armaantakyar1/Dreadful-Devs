using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject toManiplate;
    public AudioSource PlateSFX;
    public Animator plateanim;


    private void OnTriggerEnter(Collider other)
    {
        toManiplate.SetActive(true);
        plateanim.SetBool("Press", true);
        PlateSFX.Play();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Object") || other.CompareTag("Object2"))
        {
            toManiplate.SetActive(true);
        }
        if (other.CompareTag("Player1"))
        {
            toManiplate.SetActive(true);
        }
        if (other.CompareTag("Player2"))
        {
            toManiplate.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        toManiplate.SetActive(false);
        plateanim.SetBool("Release", true);
        plateanim.SetBool("Press", false);
    }

}
