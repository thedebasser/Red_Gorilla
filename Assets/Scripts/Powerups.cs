using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour {

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

			if (thePlayer.moveSpeed == 8) 
			{
				thePlayer.moveSpeed = -8;
			} 
			else if (thePlayer.moveSpeed == -8) 
			{
				thePlayer.moveSpeed = 8;			
			} 
									
		}
	}
}
	
