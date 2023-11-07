using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
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
        if (hit == true) {
            StartCoroutine(DMGIndicator(1f));
        }
        
    }

    IEnumerator DMGIndicator(float duration)
    {
        var end = Time.time + duration;
        float start = Time.time;
        hit = false;
        while(Time.time < end) {
            //shipMaterial.color = Color.Lerp(colorOff, colorOn, Mathf.Sin((Time.time-start)*6.28f*(1/duration)+1.57f)*0.5f+0.5f); //PingPong
            shipMaterial.color = Color.Lerp(colorOff, colorOn, Mathf.Sin((Time.time - start) * 6.28f - 1.57f) * 0.5f + 0.5f);
            yield return null; // Go again (while loop)
        } 
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            hit = true;
        }
    }
}