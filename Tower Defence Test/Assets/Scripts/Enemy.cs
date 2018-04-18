using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        //setting target as the castle game object
        GameObject target = GameObject.Find("Castle");

        //if target is found
        if(target)
        {
            //set Agents destination = targets transform
            GetComponent<NavMeshAgent>().destination = target.transform.position;
        }
	}

	void OnTriggerEnter(Collider tar)
	{
        //if collides with "Castle"
        if(tar.gameObject.CompareTag ("Castle"))
        {
            //call decrease() in Health Script
            tar.GetComponentInChildren<Health>().decrease();
            //destory the enemy when touches castle
            Destroy(gameObject);

        }
	}


}
