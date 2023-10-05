using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 5f;
    
    Rigidbody rb;
    


    void Start(){

        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, lifetime);
        
    }
    

    private void FixedUpdate(){
       
        //vector3..forward laver fejl med retningn på skud atm.
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);

    }
  


}
