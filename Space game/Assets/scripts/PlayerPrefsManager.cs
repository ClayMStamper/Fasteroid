using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	void Update(){

	}
	public static void SetHighScore(float highscore){
		PlayerPrefs.SetFloat ("highscore", highscore);
	}
	public static float GetHighScore(){
		return PlayerPrefs.GetFloat ("highscore");
	}
}
