using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocusManager : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	public GameObject dynamite;
	void Start () {
		player = GameObject.Find ("player");
		dynamite = GameObject.Find ("dynamite");
	}



	void Update () {
		if (CameraFocus._focus == 3) {

		} else if (CameraFocus._focus == 2) {
			Camera.main.transform.position = new Vector3 (dynamite.transform.position.x, dynamite.transform.position.y, -10);
		} else if (CameraFocus._focus == 1) {
			Camera.main.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10);

		}
	}
}
