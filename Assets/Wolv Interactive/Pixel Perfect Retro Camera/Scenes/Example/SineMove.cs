using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMove : MonoBehaviour {
	void Update () {
		transform.position = new Vector3(Mathf.Sin(Time.time) * 60, Mathf.Sin(Time.time * 0.5f) * 20, -10f);
	}
}
