using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //we establish our variables required
    [SerializeField] private float walkSpeed = 0;
    [SerializeField] private float runSpeed;
    [SerializeField] private float crouchSpeed;
    [SerializeField] private Vector3 direction;
        //Vector3 is a *struct* - a varbiale which holds other variables
            //direction.x, direction.y, direction.z

    private void Update()
    {
        //Call the Move method every frame
        Move();
    }

    private void Move()
    {
        //Set our direction based on the player's inputs (using left/right and forward/back axes)
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        //run the GetSpeed method and set "speed" to equal the result
        float speed = GetSpeed();   //GetSpeed() stands in for a number we calculate at the time

        //add our direction times our speed and deltaTime, to our current position
        transform.position += direction * speed * Time.deltaTime;
    }

    private float GetSpeed()
    {
        //Get a local float and set it to default walk speed
        float speed = walkSpeed;

        //if the player is sprinting or crouching, change the local float
        if (Input.GetKey(KeyCode.LeftShift))
            speed = runSpeed;
        if (Input.GetKey(KeyCode.LeftControl))
            speed = crouchSpeed;

        //Return the value of that float (it will equal walkSpeed, runSpeed, or crouchSpeed)
        return speed;
    }
}
