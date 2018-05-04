using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	[SerializeField] private string[] levelNames;
	private ScreenWipe screenWipe;
	private int nextLevelIndex;

	private void Awake () {
		screenWipe = FindObjectOfType<ScreenWipe> ();
		DontDestroyOnLoad (gameObject);
		StartCoroutine (LoadNextLevel ());
	}

	private IEnumerator LoadNextLevel () {
		nextLevelIndex++;
		if (nextLevelIndex >= levelNames.Length)
			nextLevelIndex = 0;

		string nextLevelName = levelNames[nextLevelIndex];

		screenWipe.ToggleWipe (true);
		while (!screenWipe.isDone)
			yield return null;

		AsyncOperation operation = SceneManager.LoadSceneAsync (nextLevelName);
		while (!operation.isDone)
			yield return null;

		screenWipe.ToggleWipe (false);
	}
}