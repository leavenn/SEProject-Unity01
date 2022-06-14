using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRb;
    public float force =  70f;

    private void FixedUpdate()
    {
       
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            playerRb.AddForce(force, 0, 0);
        }
        if(Input.GetKey("a") || Input.GetKey("left"))
        {
            playerRb.AddForce(-force, 0, 0);
        }

        //if(Input.GetKey("w") || Input.GetKey("up"))
        //{
        //    playerRb.AddForce(0, 0,force);
        //}
        //if(Input.GetKey("s") || Input.GetKey("down"))
        //{
        //    playerRb.AddForce(0, 0, -force);
        //}

        
    }

}
