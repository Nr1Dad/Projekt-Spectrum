using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Damagecolor : MonoBehaviour

{
    Material shipMaterial;

    Color colorOff = Color.white;
    Color colorOn = Color.red;
    public float colorChangeSpeed = 2;



    private void Start()
    {
        shipMaterial = GetComponent<Renderer>().material;
    }



    private void OnCollisionEnter(Collision other)
    {
        

            //FEJL HER, har brug for at blivee looped.
            if (other.gameObject.CompareTag("Bullet"))
            {
                for (int i = 0; i < 8; i++)
                { 
                shipMaterial.color = Color.Lerp(colorOff, colorOn, Mathf.PingPong(Time.time * colorChangeSpeed, 1)); 
                }
            }
    }
    

}