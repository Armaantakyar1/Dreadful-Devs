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
        if (playersOnPlate == 2)
        {
            SceneManager.LoadScene(nextscene);
        }
        
        PlateSFX.Play();
        endplateanim.SetBool("Press",true);
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (playersOnPlate == 2)
        {
            SceneManager.LoadScene(nextscene);
        }
        endplateanim.SetBool("Press", false);
        endplateanim.SetBool("Release", true);
        playersOnPlate--;
    }
}
