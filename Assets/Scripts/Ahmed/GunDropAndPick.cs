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
            newgameObject = Instantiate(gunPrefab, transform.position + transform.forward * 2f , Quaternion.identity);
            gunInHand.gameObject.SetActive(false);
            GetComponent<Shooting>().enabled = false;
            pickedUp = false;
        }
        else if (!pickedUp && distanceBetweenGun < 2
            && Input.GetKeyDown(dropButton)) 
        {
            Destroy(newgameObject);
            gunInHand.gameObject.SetActive(true);
            GetComponent<Shooting>().enabled = true;
            pickedUp = true;

        }
    }
}
