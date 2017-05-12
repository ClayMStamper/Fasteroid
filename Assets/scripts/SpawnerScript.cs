using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	
	bool timeToSpawn = false;
	public float spawnEverySeconds = 1;
	public float timeDifficultyMod = 1; // not doing anything if value = 1; larger number means easier
	public GameObject asteroidPrefab;

	void Update () {
		timeToSpawn = IsTimeToSpawn ();
		if (timeToSpawn == true) {
			Spawn ();
			timeToSpawn = false;
			if (spawnEverySeconds >= 1) {
				spawnEverySeconds -= timeDifficultyMod;
			}
			timeDifficultyMod -= timeDifficultyMod / 2;
		}
	}
	void Spawn(){
		GameObject asteroid = Instantiate (asteroidPrefab) as GameObject;
		asteroid.transform.parent = transform;
		asteroid.transform.position = transform.position;
		asteroid.transform.rotation = transform.rotation;
	}
	bool IsTimeToSpawn(){
		float meanSpawnDelay = spawnEverySeconds;
		float spawnsPerSecond = 1 / (meanSpawnDelay);

		float threshold = (spawnsPerSecond * Time.deltaTime);

		if (Random.value < threshold) {
			return true;
		}
		else return false;
	}
}
