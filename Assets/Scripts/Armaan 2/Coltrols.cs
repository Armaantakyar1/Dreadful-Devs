using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coltrols : MonoBehaviour
{
    public GameObject controls;
    public GameObject pressescape;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (controls.gameObject.activeSelf)
            {
                controls.gameObject.SetActive(false);
                pressescape.gameObject.SetActive(true);
            }
            else
            {
                controls.gameObject.SetActive(true);
                pressescape.gameObject.SetActive(false);
            }
        }



    }
}

