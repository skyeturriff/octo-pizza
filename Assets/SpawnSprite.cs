using UnityEngine;
using System.Collections;

public class SpawnSprite : MonoBehaviour {

  public GameObject prefabToSpawn;
  public float spawnDistance;
  Vector3 _lastSpawnPoint;
  float _spawnCount;

	// Use this for initialization
	void Start () {
    _lastSpawnPoint = transform.position;
    _spawnCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	  if(Vector3.Distance(_lastSpawnPoint, transform.position) > spawnDistance && spawnDistance > 0.0f) {
      GameObject spawnedObject = GameObject.Instantiate(prefabToSpawn, _lastSpawnPoint, Quaternion.identity) as GameObject;
      spawnedObject.name = "Clone #" + _spawnCount;
      spawnedObject.transform.parent = transform;

      _spawnCount++;
      _lastSpawnPoint = transform.position;
    }
	}
}
