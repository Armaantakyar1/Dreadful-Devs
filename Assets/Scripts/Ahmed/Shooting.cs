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
    [SerializeField] string playerAffected;
    [SerializeField] AudioSource scaleUpSfx;
    [SerializeField] AudioSource scaleDownSfx;
    [SerializeField] LayerMask layersToHit;
    [SerializeField] Animator animator;
    [SerializeField] string playerShootAnimation;
    float delay = 0.1f;
    private void Update()
    {
        if(Input.GetKeyDown(fireBig)) // rb on xbox game controller
        {
            scaleUpSfx.Play();
            ScaleUpShoot();
            animator.SetBool(playerShootAnimation, true);
            StartCoroutine(ResetTriggerAfterDelay(delay));
        }
        if(Input.GetKeyDown(fireSmall)) // lb on xbox game controller
        {
            scaleDownSfx.Play();
            ScaleDownShoot();
            animator.SetBool(playerShootAnimation, true);
            StartCoroutine(ResetTriggerAfterDelay(delay));
        }
    }
    void ScaleUpShoot()
    {
        Ray ray = cam1.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        ray.origin = cam1.transform.position;
        Vector3 maxSize = new Vector3(3f, 3f, 3f);
        if (Physics.Raycast(ray, out RaycastHit hit, 50f , layersToHit) && hit.transform.localScale != maxSize && (hit.collider.gameObject.CompareTag(playerAffected) || hit.collider.gameObject.CompareTag("Pickup") || hit.collider.gameObject.CompareTag("Object")))
        {
            hit.transform.localScale += new Vector3(.25f,.25f,.25f); 
        }
    }
    void ScaleDownShoot()
    {
        Ray ray = cam1.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        ray.origin = cam1.transform.position;
        Vector3 minSize = new Vector3(.25f, .25f, .25f);
        if (Physics.Raycast(ray, out RaycastHit hit, 50f , layersToHit) && hit.transform.localScale != minSize && (hit.collider.gameObject.CompareTag(playerAffected) || hit.collider.gameObject.CompareTag("Pickup") || hit.collider.gameObject.CompareTag("Object")))
        {
            hit.transform.localScale -= new Vector3(.25f, .25f, .25f);
        }
    }
    IEnumerator ResetTriggerAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        animator.SetBool(playerShootAnimation, false);
    }
    private void OnDrawGizmos()
    {
        Ray ray = cam1.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        Gizmos.color = new Color(0f,1f,0f,0.5f);
        Gizmos.DrawLine(ray.origin, ray.origin + ray.direction * 50f);
    }
}
