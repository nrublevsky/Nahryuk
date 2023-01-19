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

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            collision.attachedRigidbody.AddForce(this.transform.right * pullForce, ForceMode.Force);
        }   
    }
}
