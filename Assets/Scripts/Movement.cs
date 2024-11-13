using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Movement speed as a float
    private float _speed = 5.0f;
    
    // Store the current movement direction
    private Rigidbody _rb;
    public float force;

    // Update is called once per frame
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Update moveDirection based on input
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _rb.AddForce(Vector3.up * force * Time.deltaTime);
        }
        // Apply movement in the current direction
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}