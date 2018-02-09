﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		SceneManager.LoadScene ("Game");
	}

	public void StartLevel(string name) {
		SceneManager.LoadScene ("Main");
	}

}
