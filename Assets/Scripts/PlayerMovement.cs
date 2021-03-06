﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MAX_SPEED;

    private Rigidbody rb;

    private float x_default;
    private float y_default;

    private Vector3 goal_velocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        goal_velocity = Vector3.zero;
    }

    // FixedUpdate is called before each physics frame
    void FixedUpdate()
    {
        float x_input = Input.GetAxis("Horizontal");
        float y_input = Input.GetAxis("Vertical");

        float input_size = Mathf.Sqrt(x_input * x_input + y_input * y_input);
        if (input_size > 1)
        {
            x_input /= input_size;
            y_input /= input_size;
        }

        goal_velocity = MAX_SPEED * new Vector3(x_input, y_input, 0);

        // Temporary primitive movement method
        rb.velocity = goal_velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
