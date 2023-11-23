using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public float spinX = 2;
    public float spinY = 1;
    public float spinZ = 1;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(spinX, spinY, spinZ));
    }
}
