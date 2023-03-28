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
    private void Start()
    {
        plateRenderer = GetComponent<Renderer>();
        originalColor = plateRenderer.material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        playersOnPlate++;
        plateRenderer.material.color = pressedColor;
        if (playersOnPlate == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playersOnPlate--;
        plateRenderer.material.color = originalColor;
    }
}
