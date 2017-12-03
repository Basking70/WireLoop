using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsmoving1 : MonoBehaviour {

	public float step;
	public int radius;
	public float dirc = 0f;

	// Use this for initialization
	void Start () {
		dirc = 0;
		step = 0.2f;
		radius = 30;
	}

	// Update is called once per frame
	void Update () {

		if ((int)(dirc*5) % (int)(4 * radius * 5) / (5*radius) == 0 || (int)(dirc*5) % (int)(4 * radius * 5) / (5*radius) == 3) {
			transform.Translate (0, 0, step); 
		} 
		else {
			transform.Translate (0, 0, -step); 
		}
		dirc += step;
	}

}
