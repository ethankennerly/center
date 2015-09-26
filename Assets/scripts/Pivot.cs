using UnityEngine;
using System.Collections;

public class Pivot : MonoBehaviour {
	public float torqueMultiplier;
	public float torqueVertical;
	public float torqueHorizontal;
	public Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.constraints = RigidbodyConstraints.FreezePosition;
	}

	void TorqueAxis() {
		torqueHorizontal =  Input.GetAxis ("Mouse X");
		torqueVertical =  Input.GetAxis ("Mouse Y");
	}

	void TorquePosition() {
		torqueHorizontal =  (Input.mousePosition.x - 0.5f * Screen.width) / Screen.width;
		torqueVertical =  (Input.mousePosition.y - 0.5f * Screen.height) / Screen.height;
	}

	void FixedUpdate () {
		// TorqueAxis ();
		TorquePosition ();
		rb.AddTorque (
		              Time.deltaTime * torqueVertical * torqueMultiplier,
		              0,
		              Time.deltaTime * -torqueHorizontal * torqueMultiplier);
	}
}
