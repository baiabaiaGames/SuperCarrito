namespace MenuTemplate {

    using System.Collections.Generic;
    using System;
    using GooglePlayGames.BasicApi.SavedGame;
    using GooglePlayGames.BasicApi;
    using GooglePlayGames;
    using UnityEngine;

    public class PlayGamesManager : MonoBehaviour {

        public void Awake () {
            SignIn ();
        }

        void SignIn () {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder ().Build ();
            PlayGamesPlatform.InitializeInstance (config);
            PlayGamesPlatform.Activate ();

            Social.localUser.Authenticate ((bool success) => {
                if (success) {
                    Debug.Log ("SignIn successful");
                } else {
                    Debug.Log ("SignIn failed");
                }
            });
        }

        #region Achivements
        public static void UnlockAchivement (string id) {
            Social.ReportProgress (id, 100, success => { });
        }

        public static void IncrementAchivement (string id, int stepsToIncrement) {
            PlayGamesPlatform.Instance.IncrementAchievement (id, stepsToIncrement, success => { });
        }

        public static void ShowAchivementUI () {
            Social.ShowAchievementsUI ();
        }
        #endregion /Achivements

        #region Leaderboards
        public static void AddScoreToLeaderBoard (string leaderboardId, long score) {
            Social.ReportScore (score, leaderboardId, success => { });
        }
        public static void ShowLeaderboardUI () {
            Social.ShowLeaderboardUI ();
        }
        #endregion /Leaderboards
    }
}