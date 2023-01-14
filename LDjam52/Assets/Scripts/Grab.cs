using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{

    public Vector3 positionWithOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrabWithHand() {
        if (Input.GetKey(KeyCode.K))
        {
            Debug.Log("Grabbed");
            GetComponent<Rigidbody>().useGravity = false;
            gameObject.transform.position = this.transform.position;
            gameObject.transform.rotation = Quaternion.identity;
            gameObject.transform.parent = this.transform;
        }
    }    
}
