using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1ShootTest : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;

    float firingTimer;

    [SerializeField] private float firingRate = 0.5f;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && firingTimer <= 0f) { 
            Shoot();
            firingTimer = firingRate;
        }
        else{

            firingTimer -= Time.deltaTime;
        }
    }

    private void Shoot(){
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);

    }
}
