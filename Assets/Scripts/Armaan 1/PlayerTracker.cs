using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class PlayerTracker : MonoBehaviour
{
    Transform playerPosition;
    Vector3 lastPosition;
    GameObject playerObject;
    [SerializeField] Color lineColor;

    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player1");
        playerPosition = playerObject.GetComponent<Transform>();
        lastPosition = playerPosition.position;
        lineColor = Color.red;
       
    }

    private void Update()
    {
        if (playerPosition.position != lastPosition)
        {
            Debug.DrawLine(lastPosition, playerPosition.position, lineColor, Mathf.Infinity);
            lastPosition = playerPosition.position;
        }
    }

    public void SetLineColor(Color color)
    {
        lineColor = color;
    }
    public void ResetColor()
    {
        lineColor = Color.red;
    }
}

