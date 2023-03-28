using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPlayerPlate : MonoBehaviour
{
    private int playersOnPlate = 0;
    public Color pressedColor;
    private Color originalColor;
    private Renderer plateRenderer;
    public AudioSource PlateSFX;
    private void Start()
    {
        plateRenderer = GetComponent<Renderer>();
        originalColor = plateRenderer.material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        playersOnPlate++;
        plateRenderer.material.color = pressedColor;
        PlateSFX.Play();
        if (playersOnPlate == 2)
        {
            SceneManager.LoadScene("Victory");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playersOnPlate--;
        plateRenderer.material.color = originalColor;
    }
}
