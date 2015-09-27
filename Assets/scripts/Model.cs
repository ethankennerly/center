using UnityEngine;
using System.Collections;

/**
 * Abstract, engine-independent model.
 * http://www.toptal.com/unity-unity3d/unity-with-mvc-how-to-level-up-your-game-development 
 */
public class Model : MonoBehaviour {
	public static Model instance;
	public static bool isGamePlaying;
	public static bool isGameOver;

	void Start () {
		Model.instance = this;
		isGamePlaying = false;
		isGameOver = false;
	}
}
