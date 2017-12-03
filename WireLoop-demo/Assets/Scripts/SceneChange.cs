using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {



	void start(){

		if (!GameObject.FindGameObjectWithTag ("MainCamera").activeSelf) {
			GameObject.FindGameObjectWithTag ("MainCamera").SetActive (true);
		}
	}

	public void changeScene(int index){


		GameObject.FindGameObjectWithTag ("MainCamera").SetActive (false);
		Destroy(GameObject.FindGameObjectWithTag ("MainCamera"));
		SceneManager.LoadSceneAsync(index,LoadSceneMode.Single);

	}

		
}
