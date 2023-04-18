using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesManager : MonoBehaviour
{
    [SerializeField] int currentlyPressed;
    [SerializeField] int max;
    [SerializeField] GameObject toManipulate;

    void Update()
    {
        if (currentlyPressed == max)
        {
            toManipulate.SetActive(true);
        }
    }
    public void Activated()
    {
        currentlyPressed++;
    }

    public void Deactivated()
    {
        currentlyPressed--;
    } 
}
