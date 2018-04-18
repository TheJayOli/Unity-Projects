using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildArea : MonoBehaviour {

    //Tower Object
    public GameObject TowerPrefab;

    //When Mouse button is released over an Object
	private void OnMouseUpAsButton()
	{
        //Make the new tower over the gameobject clicked
        GameObject newTower = (GameObject)Instantiate(TowerPrefab);
        //new towers position = on top of object selected
        newTower.transform.position = transform.position + Vector3.up;

	}

}
