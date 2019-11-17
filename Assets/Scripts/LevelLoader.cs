using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

	private bool playerInZone;
	public string levelToLoad;
	public PlayerControl thePlayer;
	public LevelComplete theCompleteScreen;
	public int levelToUnlock;
	public int levelNumber;
	public int latestUnlockedLevel;
	public float playerCurrentGold;
	
	// Use this for initialization
	void Start () {
		playerInZone = false;
		thePlayer = FindObjectOfType<PlayerControl>();
		latestUnlockedLevel = PlayerPrefs.GetInt("levelReached");
		playerCurrentGold = PlayerPrefs.GetFloat("PlayerGold");
		
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInZone)
		{
			
			thePlayer.gameObject.SetActive(false);
			theCompleteScreen.gameObject.SetActive(true);
			
			if (levelNumber < latestUnlockedLevel) {
			// do nothing
			}
			else 
			{
				PlayerPrefs.SetInt("levelReached", levelToUnlock);
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){
	
		if(other.name == "Player")
		{
			playerInZone = true;
			playerCurrentGold += 20f;
			PlayerPrefs.SetFloat("PlayerGold", playerCurrentGold);
		}
	}
}
