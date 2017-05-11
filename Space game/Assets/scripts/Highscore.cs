using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

	Text text;
	public static float highscore;

	// Use this for initialization
	void Start () {
		highscore = PlayerPrefsManager.GetHighScore ();
		text = GetComponent <Text> ();
		text.text = "Highscore:" + PlayerPrefsManager.GetHighScore ();
	}
}
