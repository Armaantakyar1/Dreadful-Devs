using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Transform playerRespawnPoint;
    [SerializeField] Transform objectRespawnPoint1;
    [SerializeField] Transform objectRespawnPoint2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
}
