using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redCarMovement : MonoBehaviour
{
    float speed = 3f;
    private float speedMultiplier = 0f;
    private float accerationTime = 5f;
    private float elapsedTime = 0f;
    float accelation = 5;
    float turningSpeed = 45f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Initialize movement direction to zero
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce (transform.forward * speed, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-accelation * transform.forward);
        }

        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime); // turn left
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime); // turn right
        }*/

        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime); // Turn left
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);  // Turn right
        }
    }
}
