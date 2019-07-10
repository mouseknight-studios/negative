using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private PlayerStatus player;

    private int healthPotionValue;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerStatus>();

        healthPotionValue = 5;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Contact");

            if (gameObject.tag == "Coin")
            {
                player.incrementCoin();
            }

            if (gameObject.tag == "Key")
            {
                player.incrementKey();
            }

            if (gameObject.tag == "Health_Potion")
            {
                player.incrementHealth(healthPotionValue);
            }

            Destroy(gameObject);
        }
    }


}
