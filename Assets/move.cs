using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float rotate = 200f;
    bool drag = false;
    public GameObject cha;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    
    void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            drag = false;
        }
    }
   
    void FixedUpdate()
    {
        if (drag)
        {
            float x = Input.GetAxis("Mouse X") * rotate * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.up * x);
        }
    }
    void OnMouseDrag()
    {
       
       drag = true;
    }
}
