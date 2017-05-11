using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	void Start(){
		audioSource = GetComponent<AudioSource>();
		//audioSource.Play ();

	}
	// Update is called once per frame
	void Update () {
		
	
	}
	void OnLevelWasLoaded(int level){
		AudioClip thisLevelMusic = levelMusicChangeArray [level];
//		Debug.Log ("Playing clip " + levelMusicChangeArray[level]);

		if (thisLevelMusic) { // if there is an audio clip attatched
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
	public void changeVolume(float volume){
		audioSource.volume = volume;
	}
}
