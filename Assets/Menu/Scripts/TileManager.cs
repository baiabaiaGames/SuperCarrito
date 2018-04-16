using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

	[SerializeField] public Tiles tiles;
	[SerializeField] private Transform playerTransform;

	private float spawnZ = 0;
	private float tileLenght = 16.0f;
	private int amnTilesLoaded = 7;

	private void Start () {
		Init ();
	}

	private void Update () {

	}

	void Init () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void SpawnTile (int prefabIndex = -1) {
		GameObject go;
		// go = Instantiate () as GameObject;
	}
}