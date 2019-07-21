using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHit : MonoBehaviour
{
    // Start is called before the first frame update
    private bool hit;
    void Start()
    {
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Hit enemy!");
            hit = true;
            //gameObject.SetActive(false);
            //Destroy(other.gameObject);
        }
    }
}
