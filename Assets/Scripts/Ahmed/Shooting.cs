using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Camera cam1;

    [Header("JoyStick Mapping")]
    [SerializeField] KeyCode fireBig;
    [SerializeField] KeyCode fireSmall;

    private void Update()
    {
        if(Input.GetKeyDown(fireBig)) // rb on xbox game controller
        {
            ScaleUpShoot();
            Debug.Log("fireBig");
        }
        if(Input.GetKeyDown(fireSmall)) // lb on xbox game controller
        {
            ScaleDownShoot();
        }
    }
    void ScaleUpShoot()
    {
        Ray ray = cam1.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        ray.origin = cam1.transform.position;
        Vector3 maxSize = new Vector3(3f, 3f, 3f);
        if (Physics.Raycast(ray, out RaycastHit hit) && hit.transform.localScale != maxSize && hit.collider.gameObject.CompareTag("Player"))
        {
            hit.transform.localScale += new Vector3(.25f,.25f,.25f); 
        }
    }
    void ScaleDownShoot()
    {
        Ray ray = cam1.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        ray.origin = cam1.transform.position;
        Vector3 minSize = new Vector3(.25f, .25f, .25f);
        if (Physics.Raycast(ray, out RaycastHit hit) && hit.transform.localScale != minSize && hit.collider.gameObject.CompareTag("Player"))
        {
            hit.transform.localScale -= new Vector3(.25f, .25f, .25f);
        }
    }
    /*IEnumerator GrowGradually(RaycastHit hit)
    {
        Vector3 maxSize = new Vector3(.5f, .5f, .5f);
        Vector3 scaleIncrement = new Vector3(0.01f, 0.01f, 0.01f);

        while (hit.transform.localScale.x < maxSize.x && hit.transform.localScale.y < maxSize.y && hit.transform.localScale.z < maxSize.z)
        {
            hit.transform.localScale += scaleIncrement;
            yield return new WaitForSeconds(0.01f);
        }
    }*/
}
