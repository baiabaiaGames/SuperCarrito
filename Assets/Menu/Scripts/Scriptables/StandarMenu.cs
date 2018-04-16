using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenuAttribute (fileName = "Menu", menuName = "Menu")]
public class StandarMenu : ScriptableObject {

	public Sprite backGround;
	public MenuData[] menuData;

	/*	public Sprite playImage;
		public Sprite storeImage;
		public Sprite statsImage;
		public Sprite optionsImage;
		public Sprite coinsImage;*/

}

[System.Serializable]
public class MenuData {
	public string textEnglish;
	public string textSpanish;
	public Sprite buttonImage;
}