using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Transform playerRespawnPoint;
    [SerializeField] Transform objectRespawnPoint1;
    [SerializeField] Transform objectRespawnPoint2;
    [SerializeField] BoxCollider boxCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2"))
        {
            CharacterController characterController = other.GetComponent<CharacterController>();
            characterController.enabled = false;
            other.transform.position = playerRespawnPoint.position;
            characterController.enabled = true;
        }
        if (other.CompareTag("Player1"))
        {
            CharacterController characterController = other.GetComponent<CharacterController>();
            characterController.enabled = false;
            other.transform.position = playerRespawnPoint.position;
            characterController.enabled = true;
        }
        if(other.CompareTag("Object") || other.CompareTag("Pickup"))
        {
            other.transform.position = objectRespawnPoint1.position;
        }
        if(other.CompareTag("Object2"))
        {
            other.transform.position= objectRespawnPoint2.position;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position + boxCollider.center , boxCollider.size);

        Gizmos.color = new Color(1f, 0f, 0f, 0.3f);
        Gizmos.DrawCube(transform.position + boxCollider.center, boxCollider.size);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 1f, 0f, 1f);
        Gizmos.DrawWireCube(transform.position + boxCollider.center , boxCollider.size);

        Gizmos.color = new Color(1f, 1f, 0f, 0.3f);
        Gizmos.DrawCube(transform.position + boxCollider.center, boxCollider.size);
    }
}
