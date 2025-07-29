using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 100f;
    public float damage = 10f;
    public Camera fpsCamera;

    void Start()
    {
        
    }
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Stationary)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(fpsCamera.transform.position,fpsCamera.transform.forward, out hit, range))
        {
            if (hit.transform.CompareTag("Respawn")){
                Rigidbody rb = hit.transform.GetComponent<Rigidbody>();
                if(rb!= null)
                {
                    rb.AddForce(-hit.normal * damage, ForceMode.Impulse);

                }
            }
        }
    }
}
