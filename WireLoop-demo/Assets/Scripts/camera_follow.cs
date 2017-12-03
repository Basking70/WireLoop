using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {

	public Transform Target;
	public Camera cam;
	// Use this for initialization
	void Start () {
		//		Vector3 screenPos = cam.WorldToScreenPoint(target.position);
		//		Debug.Log("target is " + screenPos.x + " pixels from the left");

	}

	// Update is called once per frame
	void LateUpdate () {
		//transform.position = new Vector3 (Target.position.x, transform.position.y, Target.position.z);

	}
}