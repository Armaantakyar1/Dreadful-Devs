using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float speed;

    private Rigidbody rb;
    private Vector3 direction;
    private bool movingToEnd = true;
    [SerializeField] PlayerMovementController attachedPlayer;

    private void OnDisable()
    {
        attachedPlayer.ZeroDirection();
        attachedPlayer = null;
    }
   
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        direction = (endPoint.position - startPoint.position).normalized;
    }

    private void Update()
    {
        
        if (movingToEnd)
        {
            if (Vector3.Distance(transform.position, endPoint.position) < 0.1f)
            {
                direction = (startPoint.position - endPoint.position).normalized;
                movingToEnd = false;
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, startPoint.position) < 0.1f)
            {
                direction = (endPoint.position - startPoint.position).normalized;
                movingToEnd = true;
            }
        }

        rb.velocity = direction * speed;
        if (attachedPlayer)
        {
            attachedPlayer.direction = rb.velocity;
        }
        
    }
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Player2"))
        {
            attachedPlayer = other.gameObject.GetComponent<PlayerMovementController>();
   
        }
        if (other.transform.CompareTag("Player1"))
        {
            attachedPlayer = other.gameObject.GetComponent<PlayerMovementController>();

        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player2"))
        {
            attachedPlayer.ZeroDirection();
            attachedPlayer = null;
         
        }
        if (other.transform.CompareTag("Player1"))
        {
            attachedPlayer.ZeroDirection();
            attachedPlayer = null;

        }

    }
}
