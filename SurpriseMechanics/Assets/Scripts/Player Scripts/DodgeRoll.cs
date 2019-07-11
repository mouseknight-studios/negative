using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeRoll : MonoBehaviour
{
    //Committing to master
    Rigidbody2D rigid;

    public float dodgeSpeed;

    private float dodgeEndSpeed;

    private float tempDodgeSpeed;

    public float dodgeReduction;

    private Vector3 change;

    private bool dodged;
    // Start is called before the first frame update


    void Start()
    {
        //Object that holds the player's rigidbody
        rigid = GetComponent<Rigidbody2D>();

        //Boolean to keep track of when the player is in a dodged state
        dodged = false;

        //Setting the temporary dodge speed equal to the actual dodge speed
        tempDodgeSpeed = dodgeSpeed;

        //Sets the speed that ends the dodge roll
        dodgeEndSpeed = 5f;
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

        //If statement that puts the player in a dodged state whenever the player is moving and pressing the dodge button
        if (Input.GetButtonDown("Dodge") && (change.x != 0 || change.y != 0))
        {
            dodged = true;
            Debug.Log(dodged);
        }
    }

    private void FixedUpdate()
    {
        //If the player is in a dodged state, execute the dodge
        if (dodged)
        {
            dodgeRoll();

        }
    }

    void dodgeRoll()
    {
        //Applies the temp dodge speed to the player and reduces the temp value for a gradual decline
        transform.position += change * tempDodgeSpeed * Time.deltaTime;
        tempDodgeSpeed -= tempDodgeSpeed * dodgeReduction * Time.deltaTime;

        //If the temp speed falls below the dodgeEndSpeed, the dodge roll ends and the player is no longer in a dodging state
        if (tempDodgeSpeed < dodgeEndSpeed)
        {
            dodged = false;
            tempDodgeSpeed = dodgeSpeed;
        }
    }
}
