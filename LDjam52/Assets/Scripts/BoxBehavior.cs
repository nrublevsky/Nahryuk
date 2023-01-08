using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BoxBehavior : MonoBehaviour
{

    public int innerCounter;
    public int requiredCounter;

    public bool boxFull;
    public string boxName;

    public float pushForce;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddCorrect()
    {
      innerCounter++;
    }

    void DeductWrong()
    {
        innerCounter--;
    }

    void CheckReqs()
    {
        if (innerCounter == requiredCounter)
        {
            boxFull= true;
        }
    }

    void BoxFull ()
    {
        // активувати обњект з коллайдером повноти
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Daikon"))
        {
            Debug.Log("Added daikon");
            AddCorrect();
        }
        if (collision.collider.CompareTag("Raddish"))
        {
            Debug.Log("Not Daikon");
            collision.rigidbody.AddForce(new Vector3(0, Random.Range(60f, 120f), 0) * pushForce, ForceMode.Impulse);
        }
    }
}
