using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagecolor : MonoBehaviour

{
    Material shipMaterial;

    Color colorOff = Color.white;
    Color colorOn = Color.red;
    public float colorChangeSpeed = 2;
    public float colorChangeLength = 1;
    private bool hit = false;



    private void Start()
    {
        shipMaterial = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        if (hit==true)
        {
            StartCoroutine(DMGIndicator());
        }
    }


    IEnumerator DMGIndicator()
    {
        
        
            shipMaterial.color = Color.Lerp(colorOff, colorOn, Mathf.PingPong(Time.time * colorChangeSpeed, 1));
            yield return new WaitForSeconds(colorChangeLength);
        hit = false;

    }


    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            hit = true;
        }
    }


}