using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour {
	
	public string mainMenuLevel;
	
	public string nextLevel;
	
	public string levelSelect;

	public void LoadNextLevel(){
	
		Application.LoadLevel(nextLevel);
	
	}
	
	public void LevelSelect(){
		
		Application.LoadLevel(levelSelect);
	}
	
	public void QuitToMain(){
		
		Application.LoadLevel(mainMenuLevel);
	}
}
