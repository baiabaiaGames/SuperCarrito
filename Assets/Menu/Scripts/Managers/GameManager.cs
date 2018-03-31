namespace MenuTemplate {

	using System.Collections.Generic;
	using System.Collections;
	using UnityEngine;

	public class GameManager : MonoBehaviour {

		public static GameManager Instance { get; private set; }
		public static int Counter { get; private set; }

		private void Start () {
			Instance = this;
		}

		// Increase the counter variable
		public void IncrementCounter () {
			Counter++;
			UIDemo.Instance.UpdatePointsText ();
		}

		// Restart´s the Game
		public void RestartGame () {
			PlayGamesManager.AddScoreToLeaderBoard (GPGSIds.leaderboard_leaderboard, Counter);
			Counter = 0;
			UIDemo.Instance.UpdatePointsText ();
		}

	}
}