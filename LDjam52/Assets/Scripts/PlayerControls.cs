using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 20.0f;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        
    }

   // private void OnCollisionEnter(Collision c)
   // {
    //    c.transform.parent = gameObject.transform;
   // }

   // public void OnCollisionEnter(Collision col)
   // {
    //    if (col.transform.tag == "Player")
    //    {
            //transform.parent = col.transform;
    //    }
  //  }

          private void OnTriggerEnter(Collider other)
    {

        //Destroy(other.gameObject);
        transform.parent = other.transform; 
    }
}
