using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceSlide : MonoBehaviour
{
    public float pushForce;
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
        collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * pushForce, ForceMode.Force);
    }
}
