using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ConveyorScript1v2 : MonoBehaviour
{

    public GameObject[] waypoints;
    int current = 0;
    float rotspeed;
    public float speed;
    float WPradius = 1;
    public float patrolspeed = 10.0f;

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
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

    }

   
    void MovingConveyor()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

    }

}
