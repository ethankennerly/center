using UnityEngine;
using System.Collections;

public class Pivot : MonoBehaviour {
	public float torqueMultiplier;
	public float inverter = 1f;
	public float torqueVertical;
	public float torqueHorizontal;
	public float minimumDimension;
	public Rigidbody rb;

	void Start () {
		minimumDimension = Mathf.Min (Screen.width, Screen.height);
		rb = GetComponent<Rigidbody>();
		rb.constraints = RigidbodyConstraints.FreezePosition;
	}

	void TorqueAxis() {
		torqueHorizontal =  Input.GetAxis ("Mouse X");
		torqueVertical =  Input.GetAxis ("Mouse Y");
	}

	void TorquePosition() {

		torqueHorizontal =  Mathf.Min (1.0f, (Input.mousePosition.x - 0.5f * Screen.width) / minimumDimension);
		torqueVertical =  Mathf.Min(1.0f, (Input.mousePosition.y - 0.5f * Screen.height) / minimumDimension);
	}

	void FixedUpdate () {
		TorquePosition ();
		if (!Model.isGamePlaying) {
			return;
		}
		rb.AddTorque (
		              Time.deltaTime * inverter * torqueVertical * torqueMultiplier,
		              0,
		              Time.deltaTime * inverter * -torqueHorizontal * torqueMultiplier);
		if (2.0 < gameObject.transform.localScale.x) {
			gameObject.transform.localScale -= new Vector3(0.05f * Time.deltaTime, 0.0f, 0.05f * Time.deltaTime);
		}
	}
}
