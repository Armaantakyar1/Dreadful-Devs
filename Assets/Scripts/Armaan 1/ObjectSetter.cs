using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetter : MonoBehaviour
{
    [SerializeField] float targetScale = 2.0f; 
    [SerializeField] string newTag = "Object"; 
    private void Update()
    {
        if (transform.localScale.magnitude <= targetScale)
        {
            gameObject.tag = newTag;
        }
    }
}
