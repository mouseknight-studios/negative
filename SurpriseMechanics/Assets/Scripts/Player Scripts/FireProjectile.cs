using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject projectile;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If the fire button is pressed, the projectile is immediately instantiated where the fire point is
        if (Input.GetButtonDown("Fire"))
        {
            Instantiate(projectile, firePoint.position, firePoint.transform.rotation);
        }
    }
}
