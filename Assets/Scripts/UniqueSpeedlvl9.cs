using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniqueSpeedlvl9 : MonoBehaviour {

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

			mainCamera.transform.Rotate (0, 0, 180);

			thePlayer.moveSpeed = thePlayer.moveSpeed - (thePlayer.moveSpeed * 2) ;
		

		}
	}
}

