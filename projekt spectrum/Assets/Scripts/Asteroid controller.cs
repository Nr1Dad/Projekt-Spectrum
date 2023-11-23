using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Asteroidcontroller : MonoBehaviour
{

    Rigidbody rb;
    public float KnockbackStreangth;
    public float AsteroidHealth;
    public GameObject Collectable;

    public


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision other)   //detect collision
    {
<<<<<<< HEAD
        
        if (other.gameObject.CompareTag("Bullet"))   //detect if tag on collided object is "Bullet"
=======
        if (other.gameObject.CompareTag("Bullet2"))   //detect if tag on collided object is "Bullet"
>>>>>>> 392a13bac40b024add2a1bf7ff2b943e6ab6ee2c
        {
            rb.AddForce(Vector3.up * KnockbackStreangth, ForceMode.Impulse);   //Add force equal depending on set knockback streangth. Is also affected by object mass.
            if (AsteroidHealth <= 10)
            {               
                AsteroidHealth -- ;
                Instantiate(Collectable, Vector3.back, Quaternion.identity);
            }

            if (AsteroidHealth < 1)
            {
                
                Destroy(gameObject);
                Instantiate(Collectable, gameObject.transform);
            }
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            rb.AddForce(Vector3.up * KnockbackStreangth, ForceMode.Impulse);
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
