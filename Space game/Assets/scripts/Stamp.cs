using UnityEngine;
using System.Collections;

public class Stamp : MonoBehaviour {

	public GameObject smashedBG;
	public float smashAfter = 2;
	AudioSource smash;

	void Start () {
		smash = GetComponent <AudioSource> ();
		Invoke ("Smash", smashAfter);
	}
	void Smash(){
		smashedBG.SetActive (true);
		smash.Play ();
	}
}
