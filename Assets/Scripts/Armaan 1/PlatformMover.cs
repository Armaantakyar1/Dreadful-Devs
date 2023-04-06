using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float duration;
    public PlayerMovementController attachedPlayer;
    private void Update()
    {
        GetComponent<Rigidbody>().velocity = Vector3.forward;
        if (attachedPlayer)
        {
            attachedPlayer.direction = GetComponent<Rigidbody>().velocity;
        }
        //float t = Mathf.PingPong(Time.time / duration, 1f);
        //transform.position = Vector3.Lerp(startPoint.position, endPoint.position, t);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player1"))
        {
            attachedPlayer = collision.gameObject.GetComponent<PlayerMovementController>();
            //collision.gameObject.transform.SetParent(transfo
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player1"))
        {
            attachedPlayer = other.gameObject.GetComponent<PlayerMovementController>();
            //collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {

        if (collision.transform.CompareTag("Player1"))
        {
            attachedPlayer = null;
            //collision.gameObject.transform.SetParent(null);
        }
    }
}
