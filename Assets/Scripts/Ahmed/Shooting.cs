using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Camera cam1;

    [Header("JoyStick Mapping")]
    [SerializeField] string fireBig;
    [SerializeField] string fireSmall;

    private void Update()
    {
        if(Input.GetButtonDown(fireBig)) // rb on xbox game controller
        {
            ScaleUpShoot();
        }
        if(Input.GetButtonDown(fireSmall))
        {
            ScaleDownShoot();
        }
    }
    void ScaleUpShoot()
    {
        Ray ray = cam1.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        ray.origin = cam1.transform.position;

        if(Physics.Raycast(ray, out RaycastHit hit))
        {
           hit.transform.localScale += Vector3.one; 
        }
    }
    void ScaleDownShoot()
    {
        Ray ray = cam1.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        ray.origin = cam1.transform.position;

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            hit.transform.localScale -= Vector3.one;
        }
    }
}
