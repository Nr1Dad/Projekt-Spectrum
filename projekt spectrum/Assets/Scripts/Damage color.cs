using System.Collections;
using System.Collections.Generic;
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

        if (other.gameObject.CompareTag("Bullet"))
        {
            shipMaterial.color = Color.Lerp(colorOff, colorOn, Mathf.PingPong(Time.time * colorChangeSpeed, 1));



        }
    }


}