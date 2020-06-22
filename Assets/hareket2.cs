using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket2 : MonoBehaviour
{
    [SerializeField] float rotate = 200f;
    private Touch touch;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float x = Input.GetAxis("Mouse X") * rotate * Time.fixedDeltaTime;

                rb.AddTorque(Vector3.up * x);
            }
        }
    }
}
