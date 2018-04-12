using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
	private float spd = 3f;

	void Update() {
		Vector2 v = new Vector2(Input.GetAxis("Horizontal") * spd, Input.GetAxis("Vertical") * spd);

		transform.Translate(v * Time.deltaTime);
	}
}
