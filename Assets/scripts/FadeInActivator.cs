using UnityEngine;
using System.Collections;

public class FadeInActivator : MonoBehaviour {

	public GameObject panel;

	void awake(){
		panel.SetActive (true);
	}
}
