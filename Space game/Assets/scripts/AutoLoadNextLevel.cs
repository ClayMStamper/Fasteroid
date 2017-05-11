using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AutoLoadNextLevel : MonoBehaviour {

	public float autoLoadAfter = 3;

	private int next;

	// Use this for initialization
	void Start () {
		Invoke ("LoadNextLevel", autoLoadAfter);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void LoadNextLevel(){
		if (autoLoadAfter > 0) {
			next = SceneManager.GetActiveScene ().buildIndex + 1;
			SceneManager.LoadScene (next);
		}
	}
}
