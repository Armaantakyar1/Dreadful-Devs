using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PP2Level2 : MonoBehaviour
{
    //public GameObject toManiplate;
    public AudioSource PlateSFX;
    public Animator plateanim;
    public Animator ventdoor;
    public Animator ventdoor2;


    private void OnTriggerEnter(Collider other)
    {
       
        plateanim.SetBool("Press", true);
        ventdoor.SetBool("Open", true);
        ventdoor2.SetBool("Open", true);
        PlateSFX.Play();


    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            ventdoor.SetBool("Open", true);
            ventdoor2.SetBool("Open", true);
        }
        if (other.CompareTag("Player"))
        {
            ventdoor.SetBool("Open", true);
            ventdoor2.SetBool("Open", true);
        }
        if (other.CompareTag("Player1"))
        {
            //toManiplate.SetActive(false);
            ventdoor.SetBool("Open", true);
            ventdoor2.SetBool("Open", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // toManiplate.SetActive(true);
        plateanim.SetBool("Release", true);
        plateanim.SetBool("Press", false);
       // ventdoor.SetBool("Close", true);
        ventdoor.SetBool("Open", false);

       // ventdoor2.SetBool("Close", true);
        ventdoor2.SetBool("Open", false);
    }

}
