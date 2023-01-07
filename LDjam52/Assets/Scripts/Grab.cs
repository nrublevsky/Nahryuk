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
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Box") || collision.collider.CompareTag("SideBoxCollider") || collision.collider.CompareTag("InsideBoxCollider")) {
            Debug.Log("collided");
            if (Input.GetKey(KeyCode.KeypadEnter) || Input.GetKey(KeyCode.K))
            {
                Debug.Log("Grabbed");
                GetComponent<Rigidbody>().useGravity = false;
                gameObject.transform.position = this.transform.position;
                gameObject.transform.rotation = Quaternion.identity;
                gameObject.transform.parent = this.transform;
            }

        }
    }
}
