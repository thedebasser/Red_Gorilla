using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class GameManager : MonoBehaviour {
	
	public PlayerControl thePlayer;
	private Vector3 playerStartPoint;
	public float attemptsCount;
	public Text attemptsText;
	public Text levelName;
	public DeathMenu theDeathScreen;
	public Transform platformGenerator;
	private Vector3 platformStartPoint;
	private PlatformDestroyer[] platformList;
	private ScoreManager theScoreManager;
	public GameObject fireball1;
	public GameObject fireball2;
	public GameObject fireball3;
	public GameObject fireball4;
	public GameObject fireball5;
	private Vector3 fireball1Start;
	private Vector3 fireball2Start;
	private Vector3 fireball3Start;
	private Vector3 fireball4Start;
	private Vector3 fireball5Start;


	// Use this for initialization, add an else if to this section for each additional level, make sure to change the levelname inside canvas for the level
	void Start () {
		playerStartPoint = thePlayer.transform.position;
		/*fireball1Start = fireball1.transform.position;
		fireball2Start = fireball2.transform.position;
		fireball3Start = fireball3.transform.position;
		fireball4Start = fireball4.transform.position;
		fireball5Start = fireball5.transform.position;*/





		if(levelName.text == "TestScene")
		{
			if(PlayerPrefs.HasKey("AttemptsTestLevel"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsTestLevel");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "Level2")
		{
			if(PlayerPrefs.HasKey("AttemptsLevel2"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsLevel2");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "Level3")
		{
			if(PlayerPrefs.HasKey("AttemptsLevel3"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsLevel3");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "Level4")
		{
			if(PlayerPrefs.HasKey("AttemptsLevel4"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsLevel4");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "Level5")
		{
			if(PlayerPrefs.HasKey("AttemptsLevel5"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsLevel5");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "Level6")
		{
			if(PlayerPrefs.HasKey("AttemptsLevel6"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsLevel6");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "Level7")
		{
			if(PlayerPrefs.HasKey("AttemptsLevel7"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsLevel7");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "Level8")
		{
			if(PlayerPrefs.HasKey("AttemptsLevel8"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsLevel8");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "Level9")
		{
			if(PlayerPrefs.HasKey("AttemptsLevel9"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsLevel9");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "Level10")
		{
			if(PlayerPrefs.HasKey("AttemptsLevel10"))
			{
				attemptsCount = PlayerPrefs.GetFloat("AttemptsLevel10");
				attemptsText.text = "Attempt: " + attemptsCount;
			}
		}
		else if(levelName.text == "EndlessMode")
		{
			// do endless mode setup, score?
			platformStartPoint = platformGenerator.position;
			theScoreManager = FindObjectOfType<ScoreManager> ();
		}
	}
	
	// Update is called once per frame
	void Update () {

		
		
	}
	
	public void ShowAd(){
		
		if (PlayerPrefs.HasKey ("NoAds")) {
			
			// do nothing

		} else {


			// show ad
			if (Advertisement.IsReady ()) {
				Advertisement.Show ();
			}

		}
	}
	
	public void RestartGame() {
		
		attemptsCount += 1f;
		// add an additional else if statement here for each additional level
		if (levelName.text == "TestScene") {
			PlayerPrefs.SetFloat ("AttemptsTestLevel", attemptsCount);
		} else if (levelName.text == "Level2") {
			PlayerPrefs.SetFloat ("AttemptsLevel2", attemptsCount);
		} else if (levelName.text == "Level3") {
			PlayerPrefs.SetFloat ("AttemptsLevel3", attemptsCount);
		} else if (levelName.text == "Level4") {
			PlayerPrefs.SetFloat ("AttemptsLevel4", attemptsCount);
		} else if (levelName.text == "Level5") {
			PlayerPrefs.SetFloat ("AttemptsLevel5", attemptsCount);
		} else if (levelName.text == "Level6") {
			PlayerPrefs.SetFloat ("AttemptsLevel6", attemptsCount);
		} else if (levelName.text == "Level7") {
			PlayerPrefs.SetFloat ("AttemptsLevel7", attemptsCount);
		} else if (levelName.text == "Level8") {
			PlayerPrefs.SetFloat ("AttemptsLevel8", attemptsCount);
		} else if (levelName.text == "Level9") {
			PlayerPrefs.SetFloat ("AttemptsLevel9", attemptsCount);
		} else if (levelName.text == "Level10") {
			PlayerPrefs.SetFloat ("AttemptsLevel10", attemptsCount);
		} else if (levelName.text == "EndlessMode") {
			theScoreManager.scoreIncreasing = false;
		}

		thePlayer.gameObject.SetActive(false);
		theDeathScreen.gameObject.SetActive(true);
		if (attemptsCount % 8 == 0)
		{
			
			ShowAd();
			
		}

		
	}
	
	public void Reset(){

		if (levelName.text == "EndlessMode") {

			platformList = FindObjectsOfType<PlatformDestroyer> ();
			for (int i = 0; i < platformList.Length; i++) {

				platformList [i].gameObject.SetActive (false);
			}

			// add some score thing here
			theDeathScreen.gameObject.SetActive (false);
			thePlayer.transform.position = playerStartPoint;
			platformGenerator.position = platformStartPoint;
			thePlayer.gameObject.SetActive (true);
			theScoreManager.scoreCount = 0;
			theScoreManager.scoreIncreasing = true;

		} else {

			theDeathScreen.gameObject.SetActive (false);
			attemptsText.text = "Attempt: " + attemptsCount;
			thePlayer.transform.position = playerStartPoint;
			/*fireball1.transform.position = fireball1Start;
			fireball2.transform.position = fireball2Start;
			fireball3.transform.position = fireball3Start;
			fireball4.transform.position = fireball4Start;
			fireball5.transform.position = fireball5Start;*/
			thePlayer.gameObject.SetActive (true);

		}
		
	}
	
}
