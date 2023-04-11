using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coltrols : MonoBehaviour
{
    public GameObject controls;
    public GameObject pressescape;
    public Animator pressescapeanim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (controls.gameObject.activeSelf)
            {
                pressescape.gameObject.SetActive(true);
                controls.gameObject.SetActive(false);
             
            }
            else
            {
                controls.gameObject.SetActive(true);
                pressescape.gameObject.SetActive(false);
            }
        }



    }
}

