using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float movementX, movementY, rotater, maxSpeed = 30;
    [SerializeField]
    private float acceleration = 30, turnSpeed;
    private Vector2 movementVector;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue InputValue)
    {

        movementVector = InputValue.Get<Vector2>();

        Vector2 rotater = new Vector2();
        rotater.x = movementVector.x;
        rotater.y = movementVector.y;

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    void FixedUpdate()
    {

        Vector3 movement = new Vector3(0, 0f, movementY);
        rb.AddRelativeForce(movement * acceleration);
        CarRotation();

    }

    void CarRotation()
    {
        //turnSpeed gpes down as speed goes up
        //When standing still velocity is 0 and you can´t divide by zero, hence + 0.01f

        turnSpeed = 2f/(rb.velocity.magnitude + 0.01f);
        //Debug.Log(turnSpeed);
        
        //rb.velocity.magnitude ensures when car is not having a speed car can´t turn either
        transform.Rotate(0, turnSpeed * movementX * rb.velocity.magnitude, 0);
    }

    // void Powerup(int accelerationPowerIncrease)
    // {
    //     acceleration += accelerationPowerIncrease;
    // }

    public float Acceleration
    {
        get
        {
            return acceleration;
        }
        set
        {
            //make 50 a variable (no magic numbers)
            if (acceleration + value < maxSpeed)
            {
                acceleration += value;
            }
            else
            {
                acceleration = maxSpeed;
            }
        }
    }
}