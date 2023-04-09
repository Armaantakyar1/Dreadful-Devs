using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigActivator : MonoBehaviour
{
    [SerializeField] List<GameObject> objectsToActivate = new List<GameObject>();
    [SerializeField] List<GameObject> objectsToDeActivate = new List<GameObject>();
    [SerializeField] List<Shooting> gun = new List<Shooting>();
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            ActivateObjects();
        }
        if (other.CompareTag("Player2"))
        {
            ActivateObjects();
        }
    }
    void ActivateObjects()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(true);
        }
        foreach (GameObject obj in objectsToDeActivate)
        {
            obj.SetActive(false);
        }
        foreach (Shooting obj in gun)
        {
            obj.enabled=true;
        }
    }
}
