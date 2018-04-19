using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //float for movementspeed of the ball
    public float Speed = 75f;

    //declairing the ball rigidbody
    private Rigidbody RBball;

    private int spacePress = 0;

    // Use this for initialization
    void Start ()
    {
        RBball = GetComponent<Rigidbody>();


    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if(Input.GetKey(KeyCode.Space) && spacePress != 1)
        {
            Vector3 Start = new Vector3(0, 0, -1);

            RBball.AddForce(Start * Speed * Time.deltaTime);

            spacePress++;
        }

	}
}
