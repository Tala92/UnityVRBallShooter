﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
	public GameObject ballPrefab;
	public float speed = 50.0f;
	public int ballCounter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetButtonDown ("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			Camera camera = GetComponentInChildren<Camera>();
			rb.velocity = camera.transform.rotation * Vector3.forward * speed;
			ballCounter++;
			// print ("You used " + ballCounter + " balls");

		}
	}
}
