using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1PP : MonoBehaviour
{
    public AudioSource PlateSFX;
    public Animator plateanim;
    public Animator Stairs;


    private void OnTriggerEnter(Collider other)
    {
        Stairs.SetBool("up", true);
        plateanim.SetBool("Press", true);
        PlateSFX.Play();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Object") || other.CompareTag("Object2"))
        {
            Stairs.SetBool("up", true);
        }
        if (other.CompareTag("Player1"))
        {
            Stairs.SetBool("up", true);
        }
        if (other.CompareTag("Player2"))
        {
            Stairs.SetBool("up", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Stairs.SetBool("up", false);
        plateanim.SetBool("Release", true);
        plateanim.SetBool("Press", false);
    }
}
