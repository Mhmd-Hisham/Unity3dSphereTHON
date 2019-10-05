﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 5f;
    public float sidewaysForce = 20f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime, ForceMode.VelocityChange);
        
        if (Input.GetKey("s")){
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("w")){
            rb.AddForce(0, 0, +sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d")){
            rb.AddForce(+sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("q")){
            rb.AddForce(0, sidewaysForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("e")){
            rb.AddForce(0, -sidewaysForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        
        if (rb.position.y < 0){
            // Die upon falling
            FindObjectOfType<GameManager>().EndGame();

        }
        
    }
}
