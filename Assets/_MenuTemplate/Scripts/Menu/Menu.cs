using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

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
	[SerializeField] private Text[] texts;
	[SerializeField] private Dropdown lenguage;

	[SerializeField] private Image backGround;

	[SerializeField] private GameObject exitMenu;
	void Awake () {

		backGround.sprite = menu.backGround;
		exitMenu.SetActive (false);

		for (int i = 0; i < menu.menuData.Length; i++) {
			if (menu.menuData[i].textEnglish != null)
				texts[i].text = menu.menuData[i].textEnglish;
		}

	}

	void Update () {
#if UNITY_EDITOR
		if (Input.GetKeyDown ("escape") && exitMenu.activeInHierarchy == false) {
			exitMenu.SetActive (true);
		} else if (Input.GetKeyDown ("escape") && exitMenu.activeInHierarchy == true) {
			exitMenu.SetActive (false);
		}
#endif
	}

	public void Lenguage () {

		switch (lenguage.value) {
			case 0:
				for (int i = 0; i < menu.menuData.Length; i++) {
					if (menu.menuData[i].textEnglish != null)
						texts[i].text = menu.menuData[i].textEnglish;
				}
				Debug.Log ("ingles");
				break;

			case 1:
				for (int i = 0; i < menu.menuData.Length; i++) {
					if (menu.menuData[i].textSpanish != null)
						texts[i].text = menu.menuData[i].textSpanish;
				}
				Debug.Log ("español");
				break;
		}

	}

	public void Quit () {
#if UNITY_EDITOR
		EditorApplication.isPlaying = false;
#else
		Application.Quit ();
#endif
	}
}