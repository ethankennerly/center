using UnityEngine;
using System.Collections;

public class StartPlate : MonoBehaviour {
	public string myName;
	public GameObject ball;

	void Start () {
		myName = this.name;
		gameObject.SetActive (true);
		ball = GameObject.Find ("Ball");
	}
	
	void FixedUpdate() {
		if (Model.isGamePlaying && gameObject.activeSelf) {
			Debug.Log ("StartPlate.Update: Ball activated");
			gameObject.SetActive (false);
		}
	}
}
