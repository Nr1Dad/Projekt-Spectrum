using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Asteroiddropcontroller1: MonoBehaviour
{

    Rigidbody rb;
    public float KnockbackStreangth;
    public float AsteroidHealth;

    
    public Rigidbody Pickup;

    public


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision other)   //detect collision
    {
        
        if (other.gameObject.CompareTag("Bullet"))   //detect if tag on collided object is "Bullet"
        {
            rb.AddForce(Vector3.up * KnockbackStreangth, ForceMode.Impulse);   //Add force equal depending on set knockback streangth. Is also affected by object mass.
            if (AsteroidHealth <= 10)
            {
                Debug.Log("Hit");
                AsteroidHealth -- ;
            }

            if (AsteroidHealth == 4)
            {
                Rigidbody dropInstance = Instantiate(Pickup) as Rigidbody;
            }

            if (AsteroidHealth == 3) 
            {
                Rigidbody dropInstance = Instantiate(Pickup) as Rigidbody;
            }

            if (AsteroidHealth < 1)
            {
                
                Destroy(gameObject);
                Rigidbody dropInstance = Instantiate(Pickup) as Rigidbody;
            }
        }

        if ( other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))   //detect if tag on collided object is either "Player1" or "Player2"
        {
            //Physics.IgnoreCollision() skal bruge transform og sættes i void start
        }
    }

    private void spawn()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
