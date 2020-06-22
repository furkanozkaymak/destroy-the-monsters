using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetoobject : MonoBehaviour
{
    
    public Transform target;
    public float speed = 5f;
    private Transform CurrentTarget;

    void Start()
    {
       
    }

    
    void Update()
    {
        
        CurrentTarget = target;
        
        if (CurrentTarget != null)
        transform.position = Vector3.MoveTowards(transform.position, CurrentTarget.position, speed * Time.deltaTime);
    }
    
}
