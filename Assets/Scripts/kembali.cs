﻿using UnityEngine;
using System.Collections;

public class kembali : MonoBehaviour {
	
	//Use this for initialization
	void Start () {
	
	}
	
	// update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel (0);
		}
	
	}
}