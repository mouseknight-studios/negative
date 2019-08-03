using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigid;

    private float projectileSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //Once the projectile is instantiated, it is given a velocity based on the given float value and the rotation of the fire point
        rigid = GetComponent<Rigidbody2D>();
        projectileSpeed = 10f;

        rigid.velocity = transform.up * projectileSpeed;
        Debug.Log("Has fired");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
