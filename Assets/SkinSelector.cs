using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelector : MonoBehaviour {

	public PlayerControl thePlayer;
	public Animator skinSelect;

	// Use this for initialization
	void Start () {
		
		skinSelect.runtimeAnimatorController = Resources.Load ("Animations/SkinTest") as RuntimeAnimatorController;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
