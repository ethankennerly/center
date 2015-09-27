using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public string myName;
	public Rigidbody rigidBody;
	public GameObject plate;

	void Start () {
		myName = this.name;
		rigidBody = GetComponent<Rigidbody> ();
		plate = GameObject.Find ("Plate");
	}
	
	void FixedUpdate() {
		rigidBody.useGravity = Model.isGamePlaying;
		if (Model.isGamePlaying) {
			if (gameObject.transform.position.y 
			< plate.gameObject.transform.position.y - 0.5 * plate.gameObject.transform.localScale.x) {
				// Debug.Log ("Game Over");
				Model.isGamePlaying = false;
				Application.LoadLevel(0);
			}
		}
	}

	void OnMouseDown() {
		Model.isGamePlaying = true;
	}
}
