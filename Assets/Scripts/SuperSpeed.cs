﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSpeed : MonoBehaviour {

	public Camera mainCamera;
	public bool upsideDown;
	public PlayerControl thePlayer;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Player") {

			thePlayer.moveSpeed = thePlayer.moveSpeed * 2;

		}
	}
}

