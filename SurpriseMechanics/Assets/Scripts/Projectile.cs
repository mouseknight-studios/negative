using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

        rigid.velocity = transform.up * 10f;
        Debug.Log("Has fired");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
