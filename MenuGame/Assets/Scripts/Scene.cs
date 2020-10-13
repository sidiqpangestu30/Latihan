using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour {

	public void MenuScene(){
		SceneManager.LoadScene ("mainMenu");
	}
	public void LoadingScene(){
		SceneManager.LoadScene ("Loading");
	}
	public void KeluarScene(){
		Application.Quit ();
	}
}
