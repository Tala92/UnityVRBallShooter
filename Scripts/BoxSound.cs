using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSound : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision collision) {
		AudioSource source = GetComponent<AudioSource> ();
		source.Play();
	}
}
