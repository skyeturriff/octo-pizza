﻿using UnityEngine;
using System.Collections;

public class MoveSprite : MonoBehaviour {

  public float movementSpeed = 0.5f;

	// Use this for initialization
	void Start () {
    SpriteRenderer renderer = GetComponent<SpriteRenderer>();
    renderer = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
    Vector3 position = transform.localPosition;
    position.x += (movementSpeed * Time.deltaTime);
    transform.localPosition = position;
	}
}
