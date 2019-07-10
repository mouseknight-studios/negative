using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2 : MonoBehaviour
{
    //Quick note we are using PlayerMove2 script not this one

    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;

    private bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        //Gets the players rigidbody and stores it in an object
        myRigidbody = GetComponent<Rigidbody2D>();
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Zeroes the inputs each frame to avoid carryover
        change = Vector3.zero;

        //Takes in either a -1, 0, 1 based on what direction the player moves
        // -1 = left/down, 0 = no movement, 1 = right/up
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");



        //If the player is not moving
        if (change != Vector3.zero)
        {
            isMoving = true;
            //MoveCharacter();
        }
        else
        {
            isMoving = false;
        }
    }

    private void FixedUpdate()
    {
        //Checks if the moving boolean is true before moving the character
        //This is to make sure player movement is handled by FixedUpdate
        if (isMoving)
        {
            MoveCharacter();
        }
    }

    void MoveCharacter()
    {
        //Multiplies the direction from change, base speed, and the delta time to come up with movement vector and adds it to the player's current position
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }


}
