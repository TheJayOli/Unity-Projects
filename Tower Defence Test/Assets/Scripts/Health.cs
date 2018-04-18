using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {


    TextMesh HealthBar;

	// Use this for initialization
	void Start () 
    {
        //getting the textmesh component
        HealthBar = GetComponent<TextMesh>();
	}

	private void Update()
	{
        //health bar face the camera
        transform.forward = Camera.main.transform.forward;

	}
	//public function to see current health
	public int currentHealth()
    {
        //returns strings length when called
        return HealthBar.text.Length;
    }

    //public function to decrease the objects health
    public void decrease()
    {
        //if current health when hit is above 1
        if(currentHealth() > 0)
        {
            //removes one of the "-" from the health bar
            HealthBar.text = HealthBar.text.Remove(HealthBar.text.Length - 1);
        }
        //else if the string length isn't above 1, the health hits 0
        else
        {
            //destorys the castle
            Destroy(transform.parent.gameObject);
        }
    }
}
