using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControls : MonoBehaviour
{
    public float turningSpeed = 1f;
    public float thrustSpeed = 1f;
    public float maxSpeed = 100f;

    private Rigidbody rb;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * turningSpeed * turn);
        float thrust = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * thrustSpeed * thrust);
        float turnExtra = Input.GetAxis("HorizontalExtra");
        rb.AddTorque(transform.forward * turningSpeed * turnExtra);
        float turnExtra2 = Input.GetAxis("VerticalExtra");
        rb.AddTorque(transform.right * turningSpeed * turnExtra2);
    }
}
