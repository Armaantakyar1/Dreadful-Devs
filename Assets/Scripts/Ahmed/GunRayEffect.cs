using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRayEffect : MonoBehaviour
{
    ParticleSystem particle;
    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        particle.Play();
    }
}
