using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabledoor : MonoBehaviour
{
    public List<GameObject> targets = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject obj in targets)
        {
            obj.SetActive(false);
        }
    }
}
