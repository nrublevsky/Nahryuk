using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegyChecker : MonoBehaviour
{

    public GameObject box;
    public BoxBehavior boxBehavior;

    public int boxGoal;
    public int boxCurr;
    // Start is called before the first frame update
    void Start()
    {
        boxBehavior = box.GetComponent<BoxBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Daikon"))
        {
            Debug.Log("Added daikon");
            box.GetComponent<BoxBehavior>().AddCorrect();
        }
        if (collision.collider.CompareTag("Raddish"))
        {
            Debug.Log("Not Daikon");
            collision.rigidbody.AddForce(new Vector3(0, Random.Range(60f, 120f), 0) * boxBehavior.pushForce, ForceMode.Impulse);
        }
    }
}
