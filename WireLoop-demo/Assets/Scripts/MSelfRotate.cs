using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MSelfRotate : MonoBehaviour {
	public float RotateSpeed;

	void Update() {
		//transform.Rotate(Vector3.up* RotateSpeed,Space.World);
		transform.Rotate(new Vector3(0,0,1));
	}
}