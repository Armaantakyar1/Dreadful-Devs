using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject toManiplate;
    public Color pressedColor;
    private Color originalColor;
    public AudioSource PlateSFX;
    private Renderer plateRenderer;
    private void Start()
    {
        plateRenderer = GetComponent<Renderer>();
        originalColor = plateRenderer.material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        plateRenderer.material.color = pressedColor;
        toManiplate.SetActive(true);
        PlateSFX.Play();

    }
    private void OnTriggerExit(Collider other)
    {
        plateRenderer.material.color = originalColor;
        toManiplate.SetActive(false);
    }

}
