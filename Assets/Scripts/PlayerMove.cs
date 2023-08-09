using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;
    [SerializeField] private float crouchSpeed;
    [SerializeField] private Vector3 direction; //Vector3 is a struct - stores data
                                                //direction.x, direction.y, direction.z
                                                //[SerializeField] private Transform myTransform;
    [SerializeField] private int frame;

    // Start is called before the first frame update
    void Start()
    {
        //myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Application.targetFrameRate = frame;
    }

    private void Move()
    {
        //if (Input.GetKeyDown("space"))
        //{
        //    myTransform.position += Vector3.forward; //(0,0,1) + (1,1,9) = (1,1,10)
        //}
        float horizontal = 0;
        float vertical = 0;


        //if (Input.GetKey("right"))
        //    horizontal = 1;
        //if (Input.GetKey("left"))
        //    horizontal = -1;
        
        //if (Input.GetKey("up"))
        //    vertical = 1;
        //if (Input.GetKey("down"))
        //    vertical = -1;

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        direction.x = horizontal;
        direction.y = 0;
        direction.z = vertical;

        float speed = walkSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
            speed = runSpeed;
        if (Input.GetKey(KeyCode.LeftControl))
            speed = crouchSpeed;

        transform.position += direction * speed * Time.deltaTime;

        
    }
}
