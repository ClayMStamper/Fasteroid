using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public float fadeTime;

	private Image fadePanel;
	private Color currentColor = Color.black;
	private float alphaChange;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (true);
		fadePanel = GetComponent<Image> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeTime) {
			//fade in
			alphaChange = Time.deltaTime / fadeTime;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		} else {
			gameObject.SetActive (false);
		}

	
	}
}
