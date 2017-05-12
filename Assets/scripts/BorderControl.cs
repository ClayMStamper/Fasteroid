using UnityEngine;
using System.Collections;

public class BorderControl : MonoBehaviour {

	SpawnerScript[] spawners;
	SpawnerScript sampleSpawner;
	GameObject player;
	float baseSpawnEverSecondsValue;

	// Use this for initialization
	void Start () {
		sampleSpawner = FindObjectOfType <SpawnerScript> ();
		baseSpawnEverSecondsValue = sampleSpawner.spawnEverySeconds;
		spawners = FindObjectsOfType <SpawnerScript> ();
		player = FindObjectOfType <PlayerScript> ().gameObject;
	}

	void Update () {
		//Debug.Log (player.transform.position);
		if (player){ // making sure player is there to avoid errors
			if (player.transform.position.y == -5 || player.transform.position.y == 5) {
				Debug.Log ("touching border");
				foreach (SpawnerScript spawner in spawners) {
					Debug.Log (spawner);
					spawner.spawnEverySeconds = 1f;
				}
			} else if (player.transform.position.x == -3 || player.transform.position.x == 3) {
				Debug.Log ("touching border");
				foreach (SpawnerScript spawner in spawners) {
					Debug.Log (spawner);
					spawner.spawnEverySeconds = 1f;
				}
			} else {
				foreach (SpawnerScript spawner in spawners) {
					spawner.spawnEverySeconds = baseSpawnEverSecondsValue;
				}
			}
		}
	}
}