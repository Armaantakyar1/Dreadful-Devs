using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPlayerPlate : MonoBehaviour
{
    private int playersOnPlate = 0;
    public AudioSource PlateSFX;
    public Animator endplateanim;
    public string nextscene;

    private void OnTriggerEnter(Collider other)
    {
        playersOnPlate++;
        PlateSFX.Play();
        endplateanim.SetBool("Press",true);
        if (playersOnPlate == 2)
        {
            SceneManager.LoadScene(nextscene);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        endplateanim.SetBool("Press", false);
        endplateanim.SetBool("Release", true);
        playersOnPlate--;
    }
}
