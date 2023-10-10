using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public int playernumber = 1;
    public float speedDefault = 70;
    public float angularSpeedDefault = 240;
    public float angularDampingDefault = 20;
    public float maxDriftSpeed = 0.8f;

    Rigidbody rb;
    float moveInputValue;
    float angularInputValue;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Finds and saves the desired angular speed 
        float currentSpeed = rb.velocity.magnitude;
        float alphaAngularSpeed = Mathf.Clamp(currentSpeed / speedDefault, 0, 1); // current speed divided by speedDefault and clamped [0;1]
        float angularSpeed = Mathf.Lerp(angularSpeedDefault, angularDampingDefault, alphaAngularSpeed); // angularSpeed dependent on current speed

        // Drift compensation to not loose controll, when turning
        float driftCompensation;

        if (Mathf.Sign(angularInputValue) == Mathf.Sign(rb.angularVelocity.y)) // checks if input matches direction
        {
            driftCompensation = 1; // Nothing changes
        }
        else
        {
            float currentAngularSpeed = rb.angularVelocity.magnitude;
            float alphaDrift = Mathf.Clamp(currentAngularSpeed / maxDriftSpeed, 0, 1);
            driftCompensation = Mathf.Lerp(1, 2, alphaDrift);

            Debug.Log(driftCompensation);
        }

        // Add forces to move
        moveInputValue = Input.GetAxis("Vertical"); // [-1;1] back/forward input
        rb.AddRelativeForce(Vector3.forward * moveInputValue * speedDefault);

        angularInputValue = Input.GetAxis("Horizontal"); // [-1;1] left/right input
        rb.AddRelativeTorque(Vector3.up * angularInputValue * angularSpeed * driftCompensation);
    }
}