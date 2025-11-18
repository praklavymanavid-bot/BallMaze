using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   public float forwardForce = 50f;
    public float lateralForce = 15f;
    public float targetSpeed = 10f;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Start()
    {

    }

    
    void FixedUpdate()
    {
       ForwardMovement();
       lateralMovement();
    }
    void ForwardMovement()
    {
        float currentSpeed = rb.velocity.z;
        if (currentSpeed < targetSpeed)
        {
            rb.AddForce(Vector3.forward * forwardForce * Time.fixedDeltaTime, ForceMode.Force);
        }
        else if (currentSpeed > targetSpeed)
        {
            Vector3 clampedVelocity = rb.velocity;
            clampedVelocity.z = targetSpeed;
            rb.velocity = clampedVelocity;
        }
        
    }
    void lateralMovement()
    {
        float direction = Input.GetAxis("Horizontal");
        Vector3 lateralVelocity = rb.velocity;
        lateralVelocity.x = direction * lateralForce;
        rb.velocity = lateralVelocity;
        
    }
}
