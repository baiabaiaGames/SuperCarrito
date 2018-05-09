using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public float points = 0;
	public TMPro.TextMeshProUGUI pointText;
	public bool isPlaying = false;

	public List<float> scoreMultipliers = new List<float> ();

	public void ChangePoints (float p) {
		float newPoints = p;

		foreach (float multiplier in scoreMultipliers) {
			newPoints *= multiplier;
		}

		points += newPoints;

		pointText.text = "Score: " + (int) points;
	}

	public void AddScoreMultiplier (float multiplier) {
		scoreMultipliers.Add (multiplier);

		float totalMultiplier = 1;

		foreach (float f in scoreMultipliers) {
			totalMultiplier *= f;
		}

		print ("Total Multiplier is now " + totalMultiplier + ".");
	}

	public void RemoveScoreMultiplier (float multiplier) {
		scoreMultipliers.Remove (multiplier);

		float totalMultiplier = 1;

		foreach (float f in scoreMultipliers) {
			totalMultiplier *= f;
		}

		print ("Total Multiplier is now " + totalMultiplier + ".");
	}

	public void ChangePlayerSpeed (float newSpeed) {
		// Add  the new speed to the player speed
	}
}