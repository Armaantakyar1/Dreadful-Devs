using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPfeedback : MonoBehaviour
{
    public AudioSource PlateSFX;
    public Animator plateanim;

    private void OnTriggerEnter(Collider other)
    {
      
        plateanim.SetBool("Press", true);
        PlateSFX.Play();


    }
    private void OnTriggerExit(Collider other)
    {
        plateanim.SetBool("Release", true);
        plateanim.SetBool("Press", false);
    }
}
