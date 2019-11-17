using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin : MonoBehaviour {

	public Animator skinSwap;
	string skinSelected;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("Skin")) {

			skinSelected = PlayerPrefs.GetString ("Skin");
			skinSwap.runtimeAnimatorController = Resources.Load (skinSelected) as RuntimeAnimatorController;

		} else {
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
