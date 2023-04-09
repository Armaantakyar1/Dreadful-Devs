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

        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
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
          
        }
        if (other.transform.CompareTag("EndPoint"))
        {
            
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
