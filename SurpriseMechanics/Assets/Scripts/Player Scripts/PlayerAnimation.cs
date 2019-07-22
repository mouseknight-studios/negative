using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    //This vector is used to store the x and y values of the raw input axis
    private Vector2 change;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Zeroes the inputs each frame to avoid carryover
        change = Vector2.zero;

        //Takes in either a -1, 0, 1 based on what direction the player moves
        // -1 = left/down, 0 = no movement, 1 = right/up
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        //Debug.Log("Axis X value: " + change.x);
        //Debug.Log("Axis Y value: " + change.y);

        //If the player is not moving
        if (change != Vector2.zero)
        {
            //Set the animator parameter to the inputs taken from the controller
            UpdateIdleAnimations(change);
            UpdateWalkingAnimations(true);

        }
        else
        {
            UpdateWalkingAnimations(false);
        }

        if (Input.GetButtonDown("attack"))
        {
            UpdateAttackAnimations();
        }
    }

    void UpdateIdleAnimations(Vector2 change)
    {
        if (!Input.GetButton("Strafe"))
        {
            anim.SetFloat("moveX", change.x);
            anim.SetFloat("moveY", change.y);
        }

    }

    void UpdateWalkingAnimations(bool moving)
    {
        anim.SetBool("Moving", moving);
    }

    void UpdateAttackAnimations()
    {
        anim.SetTrigger("Attack");
    }
}
