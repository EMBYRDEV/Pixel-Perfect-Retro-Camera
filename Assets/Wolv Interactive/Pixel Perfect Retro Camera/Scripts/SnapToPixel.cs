using UnityEngine;
using System.Collections;

public class SnapToPixel : MonoBehaviour {
	private Camera cam;
	
	void Start() {
		cam = GetComponentInChildren<Camera>();
	}

	void LateUpdate() {
		Vector3 pos = transform.position;
		Vector3 camPos = new Vector3 (pos.x - pos.x % 1, pos.y - pos.y % 1, pos.z);	
		cam.transform.position = camPos;
	}
}
