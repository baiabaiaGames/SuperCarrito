using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	[SerializeField] public string scene;
	private ScreenWipe screenWipe;
	private int nextLevelIndex;

	IEnumerator loadSceneCoroutine;
	IEnumerator waitForVideo;

	private void Awake () {
		screenWipe = FindObjectOfType<ScreenWipe> ();
		DontDestroyOnLoad (gameObject);

		WaitForVideo ();
	}

	public void WaitForVideo () {
		if (waitForVideo != null)
			StopCoroutine (waitForVideo);

		waitForVideo = WaitForVideoCourutine ();
		StartCoroutine (waitForVideo);
	}

	public void LoadScene () {
		if (loadSceneCoroutine != null)
			StopCoroutine (loadSceneCoroutine);

		loadSceneCoroutine = LoadSceneCoroutine (scene);
		StartCoroutine (loadSceneCoroutine);
	}

	public IEnumerator WaitForVideoCourutine () {
		yield return new WaitForSeconds (11f);

		LoadScene ();
	}

	public IEnumerator LoadSceneCoroutine (string levelName) {
		screenWipe.ToggleWipe (true);
		while (!screenWipe.isDone)
			yield return null;

		AsyncOperation operation = SceneManager.LoadSceneAsync (levelName);
		while (!operation.isDone)
			yield return null;

		screenWipe.ToggleWipe (false);
	}
}