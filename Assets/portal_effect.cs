using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_effect : MonoBehaviour {

	public Camera mainCamera;
	public PlayerControl thePlayer;
	public AudioSource teleportSfx;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Player") {

			mainCamera.transform.position = new Vector3 (4, 15, -10); // why the fuck does using 4 in the x slot move the camera to x 74?
			thePlayer.transform.position = new Vector3 (69, 10); // x for the camera works normal? ????????
			teleportSfx.Play();

		}
	}
}
