using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 5f;
    
    Rigidbody rb;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Astroide"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("player"))
        {
            //her
        }

    }

    
        void Start(){
        rb = GetComponent<Rigidbody>();

        rb.AddRelativeForce(Vector3.up * speed, ForceMode.Impulse);
        Destroy(gameObject, lifetime);
        
    }
    
  


}
