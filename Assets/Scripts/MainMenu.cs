using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	
	public Text playerGold;
	public Text playerLoot;
	public float currentPlayerGold;
	public int currentPlayerLoot;
	
	void Start() {
		// use below line to delete all saved data
		//PlayerPrefs.DeleteAll();
		PlayerPrefs.SetFloat("PlayerGold", 10000);


		// setup player gold
		if (PlayerPrefs.HasKey("PlayerGold"))
		{
			currentPlayerGold = PlayerPrefs.GetFloat("PlayerGold");
			playerGold.text = "Gold: " + currentPlayerGold;
		
		}
		else 
		{
			// setup the player's gold
			PlayerPrefs.SetFloat("PlayerGold", 0f);
		}

		// setup loot boxes
		if (PlayerPrefs.HasKey ("PlayerLootBoxes")) {

			currentPlayerLoot = PlayerPrefs.GetInt ("PlayerLootBoxes");
			playerLoot.text = "x" + currentPlayerLoot;

		} else {

			PlayerPrefs.SetInt ("PlayerLootBoxes", 1);
			currentPlayerLoot = PlayerPrefs.GetInt ("PlayerLootBoxes");
			playerLoot.text = "x" + currentPlayerLoot;
		}
	
	}
	
	public void KazumaSkin() {

		PlayerPrefs.SetString ("Skin", "Kazuma");
	}

	public void GintokiSkin() {

		PlayerPrefs.SetString ("Skin", "Player");
	}

	public void PlayGame() {
		
		Application.LoadLevel("LevelSelect");

	}
	
	public void QuitGame() {
		
		Application.Quit();
	}
	
	public void OpenStore() {
		
		Application.LoadLevel("Store");

	}

	public void OpenLootBoxScene() {

		Application.LoadLevel("LootBoxTest");

	}

	public void SkinSelect() {

		Application.LoadLevel("SkinSelect");

	}
}
