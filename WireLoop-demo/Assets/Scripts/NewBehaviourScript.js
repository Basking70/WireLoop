#pragma strict

import UnityEngine.SceneManagement;

function NewGame() {
    //go to select level	
	SceneManager.LoadSceneAsync(6,LoadSceneMode.Single);

}

function Settings() {
    //setting scene
	
	SceneManager.LoadSceneAsync(2,LoadSceneMode.Single);
}

function About() {
    //about scene
	
	SceneManager.LoadSceneAsync(3,LoadSceneMode.Single);
}
function Quit() {
    // quit
    Application.Quit();
}

function MainMenu() {
    //main menu scene
	
	SceneManager.LoadSceneAsync(0,LoadSceneMode.Single);

}


function EasyLevel() {
    //Easy level scene
	
	SceneManager.LoadSceneAsync(1,LoadSceneMode.Single);

}

function MediumLevel() {
    //main menu scene
	
	SceneManager.LoadSceneAsync(5,LoadSceneMode.Single);

}

function DifficultLevel() {
    //main menu scene
	
	SceneManager.LoadSceneAsync(4,LoadSceneMode.Single);

}

function Introduction() {

	SceneManager.LoadSceneAsync(8, LoadSceneMode.Single);

}