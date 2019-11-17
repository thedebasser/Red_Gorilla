using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootBoxTesting : MonoBehaviour {

	public Button openBoxButton;
	public GameObject boxPopup;
	public GameObject boxImage;
	public GameObject sceneText;
	public Image ItemImage;
	public Text ItemText;
	public int randomItemNumber;
	public Sprite tier1;
	public Sprite tier2;
	public Sprite tier3;
	public Button buyFiveBoxes;
	public Text amountOfBoxes;
	public int playerBoxes;
	public Button mainMenuButton;
	public float playerGold;
	public Text amountOfGold;
	public Button buyWithGold;
	public GameObject buyBoxesPopup;

	// Use this for initialization
	void Start () {

		playerBoxes = PlayerPrefs.GetInt ("PlayerLootBoxes");
		amountOfBoxes.text = "x" + playerBoxes;

		playerGold = PlayerPrefs.GetFloat ("PlayerGold");
		amountOfGold.text = "Gold: " + playerGold;

		buyWithGold.interactable = false;



	}
	
	// Update is called once per frame
	void Update () {

		if (playerBoxes == 0) {

			openBoxButton.interactable = false;
		} else {

			openBoxButton.interactable = true;
		}

		if (playerGold >= 489) {

			buyWithGold.interactable = true;
		} else {

			buyWithGold.interactable = false;
		}
		
	}

	public void openBox () {

		// set up the UI
		boxPopup.SetActive (true);
		openBoxButton.gameObject.SetActive (false);
		boxImage.SetActive (false);
		sceneText.SetActive (false);
		buyFiveBoxes.gameObject.SetActive (false);
		amountOfBoxes.gameObject.SetActive (false);
		mainMenuButton.gameObject.SetActive (false);

		// perform box opening code
		playerBoxes -= 1;
		PlayerPrefs.SetInt ("PlayerLootBoxes", playerBoxes);
		randomItemNumber = Random.Range(0, 50);

		ItemText.text = "Rolled A: " + randomItemNumber;

		if (randomItemNumber >= 0 && randomItemNumber <= 35) {

			ItemImage.sprite = tier1;

		} else if (randomItemNumber >= 36 && randomItemNumber <= 47) {

			ItemImage.sprite = tier2;
		} else if (randomItemNumber >= 48) {

			ItemImage.sprite = tier3;
		}


	}

	public void closeBoxPopup () {

		// set up the UI
		boxPopup.SetActive (false);
		openBoxButton.gameObject.SetActive (true);
		boxImage.SetActive (true);
		sceneText.SetActive (true);
		buyFiveBoxes.gameObject.SetActive (true);
		amountOfBoxes.gameObject.SetActive (true);
		mainMenuButton.gameObject.SetActive (true);

		// perform any after box opening operations
		amountOfBoxes.text = "x" + playerBoxes;

	}

	public void buyBoxes () {

		playerBoxes += 5;
		PlayerPrefs.SetInt ("PlayerLootBoxes", playerBoxes);
		amountOfBoxes.text = "x" + playerBoxes;

		playerGold -= 489;
		PlayerPrefs.SetFloat ("PlayerGold", playerGold);
		amountOfGold.text = "Gold: " + playerGold;
	}

	public void openBuyBoxesPopup () {

		buyBoxesPopup.SetActive (true);

	}

	public void closeBuyBoxesPopup () {

		buyBoxesPopup.SetActive (false);
	}

	public void MainMenu () {

		Application.LoadLevel("Main Menu");
	}
}
