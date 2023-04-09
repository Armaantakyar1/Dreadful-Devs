using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PP2 : MonoBehaviour
{
    public GameObject toManiplate;
    public AudioSource PlateSFX;
    public Animator plateanim;


    private void OnTriggerEnter(Collider other)
    {
        toManiplate.SetActive(false);
        plateanim.SetBool("Press", true);
        PlateSFX.Play();


    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            toManiplate.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        toManiplate.SetActive(true);
        plateanim.SetBool("Release", true);
        plateanim.SetBool("Press", false);
    }
}
