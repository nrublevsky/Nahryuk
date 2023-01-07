using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    Rigidbody playerRb;
    public float movSpeed = 100f;
    public float jumpForce;
    public bool inAir = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move() {

        if (Input.GetKey(KeyCode.D))
        {
            playerRb.AddForce(Vector3.right * movSpeed * Time.deltaTime, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRb.AddForce(Vector3.left * movSpeed * Time.deltaTime, ForceMode.Force);
        }

        if (!inAir)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                movSpeed = 40f;
                playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                inAir= true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Floor"))
        {
            inAir = false;
            movSpeed= 100f;
        }
        if (collision.collider.CompareTag("Box"))
        {
            inAir = false;
            movSpeed = 100f;
        }
    }
}
