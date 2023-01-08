using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTaker : MonoBehaviour
{

    public float pullForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            Debug.Log("pulling");
            collision.gameObject.GetComponent<Rigidbody>().AddForce(this.transform.right * pullForce,ForceMode.Force);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Box"))
        {
            Debug.Log("pulling");
            collision.gameObject.GetComponent<Rigidbody>().AddForce(this.transform.right * pullForce, ForceMode.Force);
        }
    }
}
