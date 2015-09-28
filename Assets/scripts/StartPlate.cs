using UnityEngine;
using System.Collections;

public class StartPlate : MonoBehaviour {
	void FixedUpdate() {
		if (Model.isGamePlaying && gameObject.activeSelf) {
			// Debug.Log ("StartPlate.Update: Ball activated");
			gameObject.SetActive (false);
		}
	}
}
