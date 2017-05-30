using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public float timeTillNextLevel = 30.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			LoadNextScene();
		}
		timeTillNextLevel -= Time.deltaTime;
		if (timeTillNextLevel < 0) {
			LoadNextScene ();
		}
	}
	public void LoadNextScene(){
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//Load currentIndex + 1
		SceneManager.LoadScene(currentIndex + 1);
	}
	public void LoadSceneBefore(){
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//Load currentIndex + 1
		SceneManager.LoadScene(currentIndex - 1);
	}
}
