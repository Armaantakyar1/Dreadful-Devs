using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PP2 : MonoBehaviour
{
    //public GameObject toManiplate;
    public AudioSource PlateSFX;
    public Animator plateanim;
    public Animator ventdoor;


    private void OnTriggerEnter(Collider other)
    {
        //toManiplate.SetActive(false);
        plateanim.SetBool("Press", true);
        ventdoor.SetBool("Open", true);
        PlateSFX.Play();


    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            //toManiplate.SetActive(false);
            ventdoor.SetBool("Open", true);
        }
        if (other.CompareTag("Player"))
        {
            //toManiplate.SetActive(false);
            ventdoor.SetBool("Open", true);
        }
        if (other.CompareTag("Player1"))
        {
            //toManiplate.SetActive(false);
            ventdoor.SetBool("Open", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
       // toManiplate.SetActive(true);
        plateanim.SetBool("Release", true);
        plateanim.SetBool("Press", false);
        ventdoor.SetBool("Close", true);
        ventdoor.SetBool("Open", false);
    }
}
