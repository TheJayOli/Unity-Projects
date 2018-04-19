using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPaddle : MonoBehaviour
{

    //float for movementspeed of the paddle
    public float MoveSpeed = 75f;

    //declairing the paddle rigidbody
    private Rigidbody Paddle;

    // Use this for initialization
    void Start()
    {
        Paddle = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        Vector3 moveLeft = new Vector3(-1, 0, 0);
        Vector3 moveRight = new Vector3(1, 0, 0);


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Paddle.AddForce(moveLeft * MoveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Paddle.AddForce(moveRight * MoveSpeed * Time.deltaTime);
        }
    }
}