using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildtest : MonoBehaviour
{
    public AudioSource PlateSFX;
    public Animator plateanim;
    public Animator Door;

   void Start()
    {
        plateanim.SetBool("lightblink", true);
    }
    private void OnTriggerEnter(Collider other)
    {
        plateanim.SetBool("Press", true);
        PlateSFX.Play();
        Door.SetBool("dooropen", true);
        plateanim.SetBool("lightblink", false);

    }
    private void OnTriggerExit(Collider other)
    {

        plateanim.SetBool("Release", true);
        plateanim.SetBool("Press", false);
    }
}
