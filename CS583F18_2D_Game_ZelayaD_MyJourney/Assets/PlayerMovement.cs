﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // this update function is called once per frame
    void Update () {
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            FindObjectOfType<SoundManager>().Play("PlayerJump2");
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;

        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
            //Jump conditions
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        

    }
}
