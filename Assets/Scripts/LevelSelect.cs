using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {
		
		// create void for each level to load
		public Button[] levelButtons;
		public Text levelReachedPrefs;
		
		
	void Start()
	{
		
		int levelReached = PlayerPrefs.GetInt ("levelReached", 1);

		levelReachedPrefs.text = "Level Reached Prefs: " + levelReached;
		
		for (int i = 0; i < levelButtons.Length; i++)
		{
			if (i + 1 > levelReached)
			levelButtons[i].interactable = false;
		}

			
	}
	

	public void LoadLevel1() {
		
		Application.LoadLevel("TestScene");
		
	}
	
	public void LoadLevel2() {
		
		Application.LoadLevel("Level2");
		
	}
	
	public void LoadLevel3() {
		
		Application.LoadLevel("Level3");
		
	}
	
	public void LoadLevel4() {
		
		Application.LoadLevel("Level4");
		
	}
		
	public void LoadLevel5() {
		
		Application.LoadLevel("Level5");
		
	}
		
	public void LoadLevel6() {
		
		Application.LoadLevel("Level6");
		
	}
		
	public void LoadLevel7() {
		
		Application.LoadLevel("Level7");
		
	}
		
	public void LoadLevel8() {
		
		Application.LoadLevel("Level8");
		
	}
		
	public void LoadLevel9() {
		
		Application.LoadLevel("Level9");
		
	}
		
	public void LoadLevel10() {
		
		Application.LoadLevel("Level10");
		
	}

	public void LoadLevelEndlessMode() {

		Application.LoadLevel("EndlessMode");

	}

	public void LoadLevelMainMenu() {

		Application.LoadLevel("Main Menu");

	}
}
