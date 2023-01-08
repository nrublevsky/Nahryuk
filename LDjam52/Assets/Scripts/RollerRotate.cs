using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotationDirection;
    [SerializeField]
    float rotationAngle;

    void Start()
    {
        
    }

    // Update is called once per frame
  
    void Update()
    {
        transform.Rotate(Vector3.up, Space.World) ;
    }
}
