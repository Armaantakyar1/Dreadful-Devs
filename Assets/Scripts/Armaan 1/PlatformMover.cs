using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    [SerializeField] float duration;
    [SerializeField] float speed;
    [SerializeField] PlayerMovementController attachedPlayer;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.velocity = Vector3.forward * speed;
        if (attachedPlayer)
        {
            attachedPlayer.direction = rb.velocity;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            attachedPlayer = collision.gameObject.GetComponent<PlayerMovementController>();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("StartPoint"))
        {
            speed = 1;
        }
        if (other.transform.CompareTag("EndPoint"))
        {
            speed = -1;
        }
        if (other.transform.CompareTag("Player"))
        {
            attachedPlayer = other.gameObject.GetComponent<PlayerMovementController>();
   
        }
    }

    private void OnCollisionExit(Collision collision)
    {

        if (collision.transform.CompareTag("Player"))
        {
            attachedPlayer = null;
           
        }
    }
}
