using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coltrols : MonoBehaviour
{
    public GameObject controls;
    
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                controls.SetActive(false);
            }
            else
            {
                controls.SetActive(true);
            }

    }
  }

