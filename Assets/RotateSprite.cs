using UnityEngine;
using System.Collections;

public class RotateSprite : MonoBehaviour {

  public float rotationAngle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    Vector3 rotation = transform.localRotation.eulerAngles;
    rotation.z += rotationAngle * Time.deltaTime;
    transform.localRotation = Quaternion.Euler(rotation);
	}
}
