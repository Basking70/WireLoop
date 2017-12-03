using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MStarRotate : MonoBehaviour {
	public float RotateSpeed;

	void Update() {
		transform.Rotate(new Vector3(0,0,1));
	}
}