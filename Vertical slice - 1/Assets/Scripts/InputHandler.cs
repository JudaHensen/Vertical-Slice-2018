﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
    
    private PlayerMovement movement;

    //Horizontal Movement
    private KeyCode moveLeft = KeyCode.A;
    private KeyCode moveRight = KeyCode.D;

    //Vertical Movement
    private KeyCode moveUp = KeyCode.W;
    private KeyCode moveDown = KeyCode.S;

    //Speed
    private KeyCode throddleUp = KeyCode.LeftControl;
    private KeyCode throddleDown = KeyCode.LeftShift;

    //Actions
    private KeyCode fire = KeyCode.Mouse0;
    private KeyCode beamWeapon; // --------------------------
    private KeyCode rollOrTarget; // -------------------------- (Roll left or right) Or (Target Crafts in sight)
    private KeyCode targetNearest; // --------------------------


    private KeyCode modify; // --------------------------
    private KeyCode menu = KeyCode.Escape;
    private KeyCode shields; // --------------------------
    private KeyCode laserRecharge; // --------------------------
    private KeyCode targetingComputer; // --------------------------
    private KeyCode FineControl; // --------------------------
    private KeyCode shieldRecharge; // --------------------------
                                    //private KeyCode ; // --------------------------


    private void Start()
    {

        movement = FindObjectOfType<PlayerMovement>();
    }

    void Update ()
    {
        if (!Input.GetKey(modify))
        {
            //Movement
            if (Input.GetKey(moveUp))
            {
                //move right
                movement.MoveUp();
            }
            if (Input.GetKey(moveDown))
            {
                //move down
                movement.MoveDown();
            }
            if (Input.GetKey(moveLeft))
            {
                //move left
                movement.MoveLeft();
            }
            if (Input.GetKey(moveRight))
            {
                //move right
                movement.MoveRight();
            }


            if (Input.GetKeyDown(throddleUp))
            {
                // speed up
            }


            if (Input.GetKeyDown(throddleDown))
            {
                // slow down
            }
        } else
        // MODIFIED
        {
            if (Input.GetKeyDown(throddleUp))
            {
                // full throddle
            }
            if (Input.GetKeyDown(throddleDown))
            {
                // zero throddle
            }

            if (Input.GetKeyDown(menu))
            {
                // Beam Recharge
            }
            if (Input.GetKeyDown(shields))
            {
                // Threat Display
            }


            if (Input.GetKeyDown(beamWeapon))
            {
                // Hyperspace
            }

            //Redirect Laser
            if (Input.GetKeyDown(moveUp))
            {
                //move laser right
            }
            if (Input.GetKeyDown(moveDown))
            {
                //move laser down
            }
            if (Input.GetKeyDown(moveLeft))
            {
                //move laser left
            }
            if (Input.GetKeyDown(moveRight))
            {
                //move laser right
            }

        }
    }

}
