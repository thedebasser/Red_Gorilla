using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreScript : MonoBehaviour {
	
	public GameObject SkinsPopup;
	public GameObject GoldPopup;
	public GameObject TitleText;
	public GameObject SkinsButton;
	public GameObject GoldButton;
	public GameObject MenuButton;
	public Button AdsButton;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("NoAds")) {

			AdsButton.interactable = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OpenSkinsShop () {
		
		SkinsPopup.SetActive(true);
		TitleText.SetActive(false);
		SkinsButton.SetActive(false);
		GoldButton.SetActive(false);
		MenuButton.SetActive(false);
		AdsButton.gameObject.SetActive (false);
	}
	
	public void CloseSkinsShop () {
		
		SkinsPopup.SetActive(false);
		TitleText.SetActive(true);
		SkinsButton.SetActive(true);
		GoldButton.SetActive(true);
		MenuButton.SetActive(true);
		AdsButton.gameObject.SetActive(true);
	}
	
	public void OpenGoldShop () {
		
		GoldPopup.SetActive(true);
		TitleText.SetActive(false);
		SkinsButton.SetActive(false);
		GoldButton.SetActive(false);
		MenuButton.SetActive(false);
		AdsButton.gameObject.SetActive(false);
	}
	
	public void CloseGoldShop () {
		
		GoldPopup.SetActive(false);
		TitleText.SetActive(true);
		SkinsButton.SetActive(true);
		GoldButton.SetActive(true);
		MenuButton.SetActive(true);
		AdsButton.gameObject.SetActive(true);
	}
	
	public void RemoveAds () {
		
		PlayerPrefs.SetString ("NoAds", "Yes");
	}
	
	public void BackToMain () {
		
		Application.LoadLevel("Main Menu");
	}
}
