using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed =  1f;

    private void Start()
    {
        playerRb=GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            playerRb.AddForce(speed, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            playerRb.AddForce(-speed, 0, 0, ForceMode.VelocityChange);
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
