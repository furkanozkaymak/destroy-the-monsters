using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ateş : MonoBehaviour
{
    // Start is called before the first frame update
    public float hiz=10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward *hiz* Time.deltaTime);
        
    }
}
