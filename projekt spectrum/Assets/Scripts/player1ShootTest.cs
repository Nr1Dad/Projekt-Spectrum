using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1ShootTest : MonoBehaviour
{
    [SerializeField] private Rigidbody bulletPrefab;
    [SerializeField] private Transform firingPoint;
    [SerializeField] private float currentLaunchforce = 20;
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


       Rigidbody shootInstance = Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation) as Rigidbody;
       shootInstance.velocity = currentLaunchforce * firingPoint.up;

    }

    /*private void Fire()
    {
        // Instantiate and launch the shell.
        m_Fired = true;

        Rigidbody shellInstance = Instantiate(m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

        shellInstance.velocity = m_CurrentLaunchForce * m_FireTransform.forward;

        m_ShootingAudio.clip = m_FireClip;
        m_ShootingAudio.Play();

        m_CurrentLaunchForce = m_MinLaunchForce;


    }
    */
}
