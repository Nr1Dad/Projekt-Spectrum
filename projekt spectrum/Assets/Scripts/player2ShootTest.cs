using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2ShootTest : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPointLeft;
    [SerializeField] private Transform firingPointRight;

    float firingTimer;

    [SerializeField] private float firingRate = 0.5f;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.J) && firingTimer <= 0f)
        {
            Shoot();
            firingTimer = firingRate;
        }
        else{

            firingTimer -= Time.deltaTime;
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firingPointLeft.position, firingPointLeft.rotation);
        Instantiate(bulletPrefab, firingPointRight.position, firingPointRight.rotation);

    }
}
