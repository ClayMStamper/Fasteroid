using UnityEngine;
using System.Collections;

public class AsteroidScript : MonoBehaviour {

	float speed;

	void Start(){
		float randNum = Random.Range (-15, 15);
		transform.Rotate (0,0,randNum);
		speed = Random.Range (1, 3);
	}

	void FixedUpdate(){
		transform.Translate (Vector2.down * Time.deltaTime * speed);
	}
}
