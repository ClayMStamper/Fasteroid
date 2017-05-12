using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static float score = 0;
	Text text;

	void Start(){
		score = 0;
		text = GetComponent <Text> ();
	}

	void Update () {
		if (PlayerScript.alive == true) {
			score += Time.deltaTime;
			text.text = "Score:  " + score;
		}
		if (score > Highscore.highscore) {
			Highscore.highscore = score;
			PlayerPrefsManager.SetHighScore (score);
		}
	}
}
