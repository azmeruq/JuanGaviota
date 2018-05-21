﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loaderScene : MonoBehaviour {
	public string sceneName;
	// Use this for initialization
	public void changeScene(){
		SetSceneName (sceneName);
		SceneManager.LoadScene (sceneName);
	}

	public void SetSceneName(string sceneN){
		sceneName = sceneN;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag ("Player")){
			changeScene ();
		}
	}
}
