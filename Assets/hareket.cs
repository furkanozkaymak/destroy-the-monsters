using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    private float hiz = 0.05f;
    public GameObject character;
    void Start()
    {
        
    }

    void Update()
    {
   
        transform.Rotate(0f, 1f, 0f);
        
    }
    
}
