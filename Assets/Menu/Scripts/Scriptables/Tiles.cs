using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Single Instances/TilesHolder")]
public class Tiles : ScriptableObject {
	public tileData[] tile;
}

[System.Serializable]
public class tileData {
	public GameObject tilePrefab;
	[Range (0, 100)] public float randomPercentage;
}