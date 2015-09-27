using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public string myName;
	public Rigidbody rigidBody;
	public GameObject floor;

	void Start () {
		myName = this.name;
		rigidBody = GetComponent<Rigidbody> ();
		floor = GameObject.Find ("Floor");
	}
	
	void FixedUpdate() {
		rigidBody.useGravity = Model.isGamePlaying;
		if (Model.isGamePlaying) {
			if (gameObject.transform.position.y < floor.gameObject.transform.position.y) {
				Debug.Log ("Game Over");
				Model.isGameOver = true;
				Application.LoadLevel(0);
			}
		}
	}

	void OnMouseDown() {
		Model.isGamePlaying = true;
	}
}
