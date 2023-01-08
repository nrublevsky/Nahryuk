using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceSlide : MonoBehaviour
{
    public float pushForce;
    public Vector3 localRight;

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
        Debug.Log("touching");
        collision.gameObject.GetComponent<Rigidbody>().AddForce(this.transform.right * pushForce, ForceMode.Force);
    }private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("touching");
        collision.gameObject.GetComponent<Rigidbody>().AddForce(this.transform.right * pushForce, ForceMode.Force);
    }
}
