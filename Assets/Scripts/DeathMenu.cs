using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour {
	

	public string mainMenuLevel;	
	
	public Text adTest;
	

	public void RestartGame(){
		
		FindObjectOfType<GameManager>().Reset();
	}
	
	public void QuitToMain(){
		
		Application.LoadLevel(mainMenuLevel);
	}
}
