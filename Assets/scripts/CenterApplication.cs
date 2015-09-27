using UnityEngine;
using System.Collections;

public class CenterApplication : MonoBehaviour {
	void FixedUpdate () {
		if (Model.isGameOver) {
			Debug.Log ("Restart");
			Model.isGameOver = false;
		}
	}
}
