using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesManager : MonoBehaviour
{
    [SerializeField] int currentlyPressed;
    [SerializeField] int max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentlyPressed == max)
        {

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
