using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBusController : PlayerController
{
    public override void MoveForward()
    {
        speed = 20.0f;
        //This is where we get player input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //We move turn the vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

}