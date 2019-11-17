using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void KazumaSkin() {

		PlayerPrefs.SetString ("Skin", "Kazuma");
	}

	public void GintokiSkin() {

		PlayerPrefs.SetString ("Skin", "Player");
	}

	public void TohruSkin() {

		PlayerPrefs.SetString ("Skin", "Tohru");
	}

	public void MainMenu() {

		Application.LoadLevel ("Main Menu");
	}

}
