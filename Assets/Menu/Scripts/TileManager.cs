using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

	private Transform playerTransform;
	[SerializeField] private TilesObjects tObjects;

	private float spawnZ = 0;
	private float tileLenght = 32.0f;
	private float safeZone = 32.0f;
	private int amnTilesLoaded = 7;
	private int lastPrefabIndex = 0;

	public int spawnChance;

	private List<GameObject> activeTiles = new List<GameObject> ();

	private void Start () {
		Init ();

		for (int i = 0; i < amnTilesLoaded; i++)
			if (i < 2)
				SpawnTile (0);
			else
				SpawnTile ();
	}

	private void Update () {
		// Tick ();
	}

	void Init () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

		if (tObjects == null)
			tObjects = Resources.Load ("Tiles Objects") as TilesObjects;
	}

	void Tick (OpenDirections op) {
		GameObject go;
		// OpenDirections op = go.GetComponent<OpenDirections> ();
		switch (op) {
			case OpenDirections.Front:
				if (playerTransform.position.z - safeZone > (spawnZ - amnTilesLoaded * tileLenght)) {
					SpawnTile ();
				}
				break;
			case OpenDirections.Left:
				break;
			case OpenDirections.Right:
				break;
			case OpenDirections.LeftAndRight:
				break;
			case OpenDirections.FrontLeftAndRight:
				break;
		}
		// DeleteTile ();
	}

	void SpawnTile (int prefabIndex = -1) {
		GameObject go;
		if (prefabIndex == -1)
			go = Instantiate (tObjects.tiles[RandomPrefabIndex ()].prefab) as GameObject;
		else
			go = Instantiate (tObjects.tiles[prefabIndex].prefab) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = Vector3.forward * spawnZ;
		spawnZ += tileLenght;
		activeTiles.Add (go);
	}

	/*void SpawnTile () {
		int calc_SpawnChance = Random.Range (0, 100);
		if (calc_SpawnChance <= spawnChance) {
			int tileWeight = 0;

			for (int i = 0; i < tObjects.tiles.Length; i++) {
				tileWeight += tObjects.tiles[i].probability;
			}
			Debug.Log ("TileWeight" + tileWeight);

			int randomValue = Random.Range (0, tileWeight);
		}
	}*/

	void DeleteTile () {
		Destroy (activeTiles[0]);
		activeTiles.RemoveAt (0);
	}

	private int RandomPrefabIndex () {
		if (tObjects.tiles.Length <= 1)
			return 0;

		int randomIndex = lastPrefabIndex;
		while (randomIndex == lastPrefabIndex) {
			randomIndex = Random.Range (0, tObjects.tiles.Length);
		}
		lastPrefabIndex = randomIndex;
		return randomIndex;
	}
}