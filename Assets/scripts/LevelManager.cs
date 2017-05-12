using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

	//public float autoLoadAfter = 0;

	//private int next;


	void Start(){
		//if (autoLoadAfter == 0) {
		//	Debug.Log ("Auto load next level disabled");
		//} 
		//else if (autoLoadAfter != 0) {
		//	Invoke ("LoadNextLevel", autoLoadAfter);
		//}
	}

    public void LoadLevel(string name){
		//Debug.Log ("New Level load: " + name);
		//Application.LoadLevel (name);
		SceneManager.LoadScene(name);
	}

	public void QuitRequest(){
		//Debug.Log ("Quit requested");
		Application.Quit ();
	}
	public void LoadNextLevel(){
		int index = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (index + 1);
	}
}