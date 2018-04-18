using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10;
    public Transform target;

    void FixedUpdate()
    {
        if (target)
        {
            //fly towards teh target
            Vector3 direction = target.position - transform.position;
            //set the speed of the bullet
            GetComponent<Rigidbody>().velocity = direction.normalized * speed;
        }
        else
        {
            //destory if no target
            Destroy(gameObject);
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponentInChildren<Health>();

        if(health)
        {
            health.decrease();
            Destroy(gameObject);
        }
    }
}
