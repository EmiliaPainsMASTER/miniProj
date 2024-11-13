using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Movement speed as a float
    public float _speed = 5.0f;

    // Store the current movement direction
    public Vector3 _moveDirection = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        // Update moveDirection based on input
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _moveDirection = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _moveDirection = Vector3.right;
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _moveDirection = Vector3.forward;
        }

        // Apply movement in the current direction
        transform.Translate(_moveDirection * _speed * Time.deltaTime);
    }
}