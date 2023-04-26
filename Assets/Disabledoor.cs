using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabledoor : MonoBehaviour
{
    public List<GameObject> targets = new List<GameObject>();
    public List<Animator> animator = new List<Animator>();
    [SerializeField] string door;
   
    void Start()
    {
        
    }


    void Update()
    {
        foreach (Animator animator in animator)
        {
            animator.SetBool(door, true);
        }
    }
}
