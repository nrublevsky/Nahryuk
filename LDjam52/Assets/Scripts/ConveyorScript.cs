using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConveyorScript : MonoBehaviour
{

    public GameObject[] waypoints;
    int current = 0;
    float rotspeed;
    public float speed;
    float WPradius = 1;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position,transform.position) < WPradius) 
        
        {
            current++;
            if(current>=waypoints.Length) 
            
            {
                current = 0; 
            
            }
        
        }
        InvokeRepeating("MovingConveyor", 8, 6);

    }

   
    void MovingConveyor()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

    }

}
