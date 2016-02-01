using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {
  // Value given from editor.
  public GameObject prefabToSpawn = null;
  GameObject _spawnedObject = null;

	// Use this for initialization
	void Start () {

    _spawnedObject = GameObject.Instantiate(prefabToSpawn) as GameObject;
    _spawnedObject.name = "Three Potions";
    // Setting ourselves to be the parent of our new spawned object.
    _spawnedObject.transform.parent = transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
