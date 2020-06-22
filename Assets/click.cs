using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public GameObject fire;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            

    }
    void OnMouseOver()
    {
        fire.transform.Translate(Vector3.forward * 1f * Time.deltaTime);
    }
}
