using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadAfterVideoClip : MonoBehaviour {

	public VideoClip video;
	public SceneLoader sceneLoader;

	public float time;

	private void Awake () {
		time = (float) video.length;
		StartCoroutine (videoClipLength ());
	}

	void LoadScene () {
		sceneLoader.LoadScene ();
	}

	public IEnumerator videoClipLength () {
		yield return new WaitForSeconds (time);

		LoadScene ();
	}

}