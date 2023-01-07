using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerBehavior : MonoBehaviour
{
    public GameObject blocker;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBlockingOn()
    {
        GameObject.Find("Blocker").gameObject.transform.position = new Vector3(2.956f, -0.35f, -6.88f);
    }
    public void SetBlockingOff()
    {
        GameObject.Find("Blocker").gameObject.transform.position = new Vector3(2.956f, -0.7f, -6.88f);
    }
}
