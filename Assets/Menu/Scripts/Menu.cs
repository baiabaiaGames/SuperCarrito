using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour {

	#region IdItems
	/*
		Buttons= 
		0.Play
		1.Store
		2.Stats
		3.Options
		4.Coins
		5.Back
		6.

		Texts=
		0.Play
		1.Store
		2.Stats
		3.Options
		4.Coins
		5.Volume
		6.Brightness
		7.back
		8.

	*/
	#endregion
	public StandarMenu menu;
	[SerializeField] private GameObject options;
	[SerializeField] private GameObject mainMenu;
	[SerializeField] private Image[] buttonsImage;
	[SerializeField] private Text[] texts;
	[SerializeField] private Dropdown lenguage;

	[SerializeField] private Image backGround;
	void Start () {

		backGround.sprite = menu.backGround;

		for (int i = 0; i < menu.buttonsImage.Length; i++) {
			buttonsImage[i].sprite = menu.buttonsImage[i];
			buttonsImage[i].SetNativeSize ();
		}

		for (int i = 0; i < menu.textsEnglish.Length; i++) {
			texts[i].text = menu.textsEnglish[i];
		}

	}
	public void PlayButton (string name) {
		SceneManager.LoadScene (name);
	}
	public void StoreButton () {
		Debug.Log ("store");
	}
	public void StatsButton () {
		Debug.Log ("stats");
	}
	public void OptionsButton () {
		options.SetActive (true);
		mainMenu.SetActive (false);
	}
	public void CoinsButton () {
		Debug.Log ("coins");
	}

	public void ReturnToMenu () {
		options.SetActive (false);
		mainMenu.SetActive (true);
	}

	public void Lenguage () {

		switch (lenguage.value) {
			case 0:
				for (int i = 0; i < menu.textsEnglish.Length; i++) {
					texts[i].text = menu.textsEnglish[i];
				}
				Debug.Log ("ingles");
				break;

			case 1:
				for (int i = 0; i < menu.textsSpanish.Length; i++) {
					texts[i].text = menu.textsSpanish[i];
				}
				Debug.Log ("español");
				break;
		}

	}

}