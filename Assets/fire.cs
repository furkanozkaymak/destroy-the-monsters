using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject spawn;
    public GameObject ObjectToSpawn;
    private string time = DateTime.Now.ToString("yyyyMMddHHmmssfff");


    void Start()
    {

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (long.Parse(getCurrentTime()) >= long.Parse(getTime()) + 200)
            {
                Instantiate(ObjectToSpawn, spawn.transform.position, spawn.transform.rotation);
                setCurrentTime();
            }
        }
    }

    void setCurrentTime()
    {
        this.time = getCurrentTime();
    }
    string getTime()
    {
        return this.time;
    }
    string getCurrentTime()
    {
        return DateTime.Now.ToString("yyyyMMddHHmmssfff");
    }
    void OnMouseDown()
    {

       
    }
    

}
