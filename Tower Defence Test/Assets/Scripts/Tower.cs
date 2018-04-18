using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject BulletPreFab;

    public float RotationSpeed = 35;


	// Update is called once per frame
	void Update ()
    {
        //roate the tower to look cooler
        transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if the component is an enemy
        if(other.GetComponent<Enemy>())
        {
            //create a bullet and target the enemy
            GameObject shot = (GameObject)Instantiate(BulletPreFab, transform.position, Quaternion.identity);
            shot.GetComponent<Bullet>().target = other.transform;
        }

    }
}
