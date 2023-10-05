using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotatePlayer : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(0, 5, 0);
    }
}
