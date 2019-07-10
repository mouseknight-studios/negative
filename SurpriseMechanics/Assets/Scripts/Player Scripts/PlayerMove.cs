using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Quick note we are using PlayerMove2 script not this one. This one still works but it's done off of the update method
    public float playerSpeed;
    float playerVelocityX;
    float playerVelocityY;

    private bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkMove();
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            checkMove();
        }
    }

    void checkMove()
    {
        playerVelocityX = playerSpeed * Input.GetAxisRaw("Horizontal");
        playerVelocityY = playerSpeed * Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(playerVelocityX, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, playerVelocityY);


    }
}
