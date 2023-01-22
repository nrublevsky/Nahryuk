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

    public IEnumerator DestroyInBox()
    {
        yield return new WaitForSeconds(1);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Veg"))
        {
            //check for veg name
            //if (correct veg name) {
            //add 1
            //}
            StartCoroutine(DestroyInBox());
            Destroy(collision.gameObject);
        }
        if (collision.collider.CompareTag("NonVeg"))
        {
            //penalty
            
            StartCoroutine(DestroyInBox());
            Destroy(collision.gameObject);
        }
    }
}
