using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerRotate : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    float rotationAngle;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down, rotationAngle) ;
    }
}
