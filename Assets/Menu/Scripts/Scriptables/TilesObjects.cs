using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Objects/Tiles")]
public class TilesObjects : ScriptableObject {
	public TilesData[] tiles;
}

[System.Serializable]
public class TilesData {
	public GameObject prefab;
	public OpenDirections openDirections; 

	[Range (0, 100)] public int probability;
}
public enum OpenDirections { Front, Left, Right, LeftAndRight, FrontLeftAndRight };