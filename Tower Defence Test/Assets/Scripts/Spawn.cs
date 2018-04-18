using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    //get the emeny prefab
    public GameObject EnemyPreFab;

    //spawn delay of monsters
    public float SpawnDelay = 3f;

	// Use this for initialization
	void Start () 
    {
        //spawns then waits the time of spawn delay
        InvokeRepeating("SpawnNext", SpawnDelay, SpawnDelay);
	}
	
    void SpawnNext()
    {
        //spawns the next enemy at the position and rotation of the prefab
        Instantiate(EnemyPreFab, transform.position, Quaternion.identity);
    }
}
