using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    private int playerHealth;
    private int playerMaxHealth;
    private int keys;
    private int coins;

    public Text healthText;
    public Text keyText;
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        playerMaxHealth = 7;
        playerHealth = 1;
        keys = 0;
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = playerHealth.ToString();
        keyText.text = keys.ToString();
        coinText.text = coins.ToString();

    }

    public void incrementKey()
    {
        keys++;
    }

    public void incrementCoin()
    {
        coins++;
    }

    public void incrementHealth(int healthToGive)
    {
        playerHealth += healthToGive;

        if (playerHealth > playerMaxHealth)
        {
            playerHealth = playerMaxHealth;
        }
    }
}
