using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingSign : MonoBehaviour {

	public float step;
	public int radius;
	public float dirc = 0f;

	//	public GameObject loadsign;

	// Use this for initialization
	void Start () {

		//		loadsign = GameObject.FindWithTag("loadingsign");
		//		loadsign.SetActive(false);

		transform.localScale = new Vector3(0, 2, 2);


		dirc = 0;
		step = 0.2f;
		radius = 30;
	}

	// Update is called once per frame
	void Update () {


		transform.Rotate(0, 0, -1);
		//		transform.Translate (4, 4, 4);
	}

}