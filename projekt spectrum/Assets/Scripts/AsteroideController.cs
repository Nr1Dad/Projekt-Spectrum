using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideController : MonoBehaviour
{

    Rigidbody rb;
    public float KnockbackStreangth;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision other)   //detect collision
    {
        if (other.gameObject.CompareTag("Bullet"))      //collision med en bullet
        {
            rb.AddForce(Vector3.up * KnockbackStreangth, ForceMode.Impulse);    //Add Force svarende til Knockback Streangth
        }

        if (other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))  //collision med et skib
        {
            //Physics.IgnoreCollision() - Skal bruge transforms og sættes i void start()
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
