﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel (string name) {
		Debug.Log("Level load requested for: " + name);
		Application.LoadLevel(name);
	}

	public void QuitRequest() {
		Debug.Log("I want to quit!!");
		Application.Quit();
	}

    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    //Message
    public void BrickDestroyed()
    {
        if (Brick.breakableCount <= 0) // last brick was destroyed
        {
            LoadNextLevel();
        }
    }
}
