using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehavior : MonoBehaviour
{

    public int innerCounter;
    public int requiredCounter;

    public bool boxFull;
    public string boxName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void AddCorrect()
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
}
