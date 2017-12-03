#pragma strict

var loadsign: GameObject;

function show() {
	//go to select level	
	loadsign = GameObject.FindWithTag("loadingsign");
	loadsign.transform.localScale = new Vector3(2, 2, 2);

}

function hide() {
	//go to select level	
	loadsign = GameObject.FindWithTag("loadingsign");
	loadsign.transform.localScale = new Vector3(0, 2, 2);

}