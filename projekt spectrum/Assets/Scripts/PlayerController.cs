using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public int playernumber = 1;
    public float speedDefault = 70;
    public float turnSpeedDefault = 240;
    public float turnDampingDefault = 20;

    private Rigidbody rb;              
    private float moveInputValue;
    private float turnInputValue;            

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float alphaTS = Mathf.Clamp(rb.velocity.magnitude / speedDefault, 0, 1); // current speed divided by speed and clamped [0;1]
        float turnSpeed = Mathf.Lerp(turnSpeedDefault, turnDampingDefault, alphaTS); // turnSpeed dependent on current speed

        moveInputValue = Input.GetAxis("Vertical"); // [-1;1] back/forward input
        rb.AddRelativeForce(Vector3.forward * moveInputValue * speedDefault);

        turnInputValue = Input.GetAxis("Horizontal"); // [-1;1] left/right input
        transform.Rotate(Vector3.up * turnInputValue * turnSpeed * Time.deltaTime);
    }
}