using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLook : MonoBehaviour {

	public Transform target;
	// Use this for initialization
	void Start () {

		this.transform.LookAt(target,Vector3.up);
		this.transform.Rotate (90,180,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
