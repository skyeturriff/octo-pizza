using UnityEngine;
using System.Collections;

public class SlideSprite : MonoBehaviour {

  public Vector2 slideConstraints;
  public float slideSpeed;
  float direction = 1.0f;

	// Use this for initialization
	void Start () {
    Vector3 initialPosition = transform.localPosition;
    initialPosition.x = slideConstraints.x;
    transform.localPosition = initialPosition;
	}
	
	// Update is called once per frame
	void Update () {
    Vector3 currentPosition = transform.localPosition;
    if(currentPosition.x >= slideConstraints.x && currentPosition.x <= slideConstraints.y) {
      currentPosition.x += (slideSpeed * Time.deltaTime) * direction;
    }

    if(currentPosition.x < slideConstraints.x) {
      currentPosition.x = slideConstraints.x;
      direction = 1.0f;
    }
    else if(currentPosition.x > slideConstraints.y) {
      currentPosition.x = slideConstraints.y;
      direction = -1.0f;
    }

    transform.localPosition = currentPosition;
	}
}
