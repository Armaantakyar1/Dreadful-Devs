using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualPressurePlate : MonoBehaviour
{

    private bool player1Entered = false;
    private bool player2Entered = false;
    public Animator DoorOpen;
    public Animator plateanim;
    public AudioSource PlateSFX;

    private void OnTriggerEnter(Collider other)
    {
        PlateSFX.Play();
        plateanim.SetBool("Press", true);
        if (other.gameObject.name == "Player1")
        {
            player1Entered = true;
        }
        else if (other.gameObject.name == "Player2")
        {
            player2Entered = true;
        }

        if (player1Entered && player2Entered)
        {
            EndEvent();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        plateanim.SetBool("Release", true);
        plateanim.SetBool("Press", false);
        if (other.gameObject.name == "Player1")
        {
            player1Entered = false;
        }
        else if (other.gameObject.name == "Player2")
        {
            player2Entered = false;
        }

    }
    void EndEvent()
    {
        DoorOpen.SetBool("dooropen", true);
    }
}
