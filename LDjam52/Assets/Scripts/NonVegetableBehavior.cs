using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonVegetableBehavior : MonoBehaviour
{
    
    public GameManager gm;
    public string vegName;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.CompareTag("InsideBoxCollider"))
        {

            Destroy(gameObject);


        }
    }
}
