using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCamera : MonoBehaviour
{
    private float speed;
    private float turnSpeed = 60.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();

    }

    public virtual void MoveForward()
    {

        //This is where we get player input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //We move turn the vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    public void RedTruckSpeed()
    {
        speed = 30.0f;
    }

    public void BlueBusSpeed()
    {
        speed = 20.0f;
    }

    public void ArmourTruckSpeed()
    {
        speed = 5.0f;

    }
}
