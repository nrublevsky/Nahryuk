using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BlockerBehavior : MonoBehaviour
{
    public GameObject blocker;
    public float swichedOnY;
    public float swichedOffY;

    public float movSpeed;

    private Vector3 currPosition;

    public bool blocking = true;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBlocking()
    {
        
        blocking = !blocking;
        
        Vector3 targPosition = blocker.transform.position;
        if (blocking)
        {
            targPosition.y = swichedOnY;
            currPosition = transform.position;
            transform.position = targPosition;
        }
        else
        {
            targPosition.y = swichedOffY;
            currPosition = transform.position;
            transform.position = targPosition;
        }
    }
}
