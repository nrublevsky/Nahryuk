using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeByHand : MonoBehaviour
{

    public bool carrying;
    public bool colliding;

    public GameObject collidingObject;
    public GameObject player;

    private float playerMass;

    // Start is called before the first frame update
    void Start()
    {
        playerMass = player.GetComponent<Rigidbody>().mass;
    }

    // Update is called once per frame
    void Update()
    {
        Carrying();
    }

    public void Carrying()
    {
        //check position
        if (colliding && collidingObject != null)
        {
            if (Input.GetKey(KeyCode.K))
            {
                carrying= true;
                collidingObject.GetComponent<Rigidbody>().useGravity = false;
                collidingObject.transform.SetPositionAndRotation(this.transform.position, Quaternion.identity);
                collidingObject.transform.parent = this.transform;
            }
            if (Input.GetKeyUp(KeyCode.K))
            {
                carrying= false;
                collidingObject.GetComponent<Rigidbody>().useGravity = true;
                collidingObject.transform.parent = null;
            }
        }
        if (colliding && collidingObject == null)
        {
            colliding = false;
            carrying= false;
        }
        

        if (carrying) {
        playerMass += 0.1f;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Box"))
        {
            Debug.Log("f");
            colliding = true;

            collidingObject= collision.gameObject;
        }
        
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Box"))
        {
            Debug.Log("s");
            colliding = false;

            collidingObject = null;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
