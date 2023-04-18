using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjectManager : MonoBehaviour
{
    public List<GameObject> targets = new List<GameObject>();
    public List<Animator> animators = new List<Animator>();
    [SerializeField] bool enableObject;
    [SerializeField] bool disableObject;
    [SerializeField] bool enableAnimation;
    [SerializeField] bool disableAnimation;
    [SerializeField] string pickup;
    [SerializeField] string player;
    [SerializeField] string player1;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(pickup))
        {
            Enable();
        }
        if (other.CompareTag(player))
        {
            Enable();
        }
        if (other.CompareTag(player1))
        {
            Enable();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(pickup))
        {
            Enable();
        }
        if (other.CompareTag(player))
        {
            Enable();
        }
        if (other.CompareTag(player1))
        {
            Enable();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(pickup))
        {
            disable();
        }
        if (other.CompareTag(player))
        {
            disable();
        }
        if (other.CompareTag(player1))
        {
            disable();
        }
    }
    private void Enable()
    {
        foreach (GameObject obj in targets)
        {
            obj.SetActive(enableObject);
        }

        foreach (Animator animator in animators)
        {
            animator.enabled = enableAnimation;
        }
    }
    void disable()
    {
        foreach (GameObject obj in targets)
        {
            obj.SetActive(disableObject);
        }

        foreach (Animator animator in animators)
        {
            animator.enabled = disableAnimation;
        }
    }
}
