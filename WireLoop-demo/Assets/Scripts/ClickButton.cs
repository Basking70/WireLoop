using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour {
	public Text scoreText;
	public void Click(){
		scoreText.text = "Clicked";
		//Still not working in kudan
		//SceneManager.LoadScene (1);
	}
}
