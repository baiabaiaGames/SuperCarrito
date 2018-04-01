namespace MenuTemplate {

	using UnityEngine.UI;
	using UnityEngine;

	public class UIDemo : MonoBehaviour {

		public static UIDemo Instance { get; private set; }

		private void Start () {
			Instance = this;
		}

		[SerializeField]
		private Text pointsTxt;
		public void GetPoint () {
			GameManager.Instance.IncrementCounter ();
		}

		// Restart the UI Variables
		public void Restart () {
			GameManager.Instance.RestartGame ();
		}

		// Increment the the steps of the achivement to Unlock
		public void Increment () {
			PlayGamesManager.IncrementAchivement (GPGSIds.achievement_incremental_achivement, 5);
		}

		// Unlock an Achivement
		public void Unlock () {
			//Pass the Achivement you want to Unlock from the GPSIds Script
			PlayGamesManager.UnlockAchivement (GPGSIds.achievement_test_achivement1);
		}

		// Show Google Play Games Achivements in the UI
		public void ShowAchivements () {
			PlayGamesManager.ShowAchivementUI ();
		}

		// Show Google Play Games Leaderboard in the UI
		public void ShowLeaderboards () {
			PlayGamesManager.ShowLeaderboardUI ();
		}

		public void UpdatePointsText () {
			pointsTxt.text = GameManager.Counter.ToString ();
		}

	}
}