using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunDropAndPick : MonoBehaviour
{
    [SerializeField] GameObject gunPrefab;
    [SerializeField] GameObject gunInHand;
    [SerializeField] KeyCode dropButton;
    GameObject newgameObject;

    float distanceBetweenGun;
    bool pickedUp= true;

   

    void DistanceFromGun()
    {
        distanceBetweenGun = Vector3.Distance(transform.position, newgameObject.transform.position);
    }
    private void Update()
    {
        if(newgameObject != null)
        {
            DistanceFromGun();

        }
        if(pickedUp && Input.GetKeyDown(dropButton)) 
        { 
            newgameObject = Instantiate(gunPrefab, transform.position, Quaternion.identity);
            gunInHand.gameObject.SetActive(false);
            pickedUp = false;
        }
        else if (!pickedUp && distanceBetweenGun < 2
            && Input.GetKeyDown(dropButton)) 
        {
            Destroy(newgameObject);
            gunInHand.gameObject.SetActive(true);
            pickedUp = true;

        }
    }
}
