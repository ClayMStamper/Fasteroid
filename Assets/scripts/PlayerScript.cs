using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	float speed = 0;
	float turnSpeed;
	public static bool alive;
	LevelManager levelManager;

	bool rightTurnBool = false;
	bool leftTurnBool = false;
	bool accelerateBool = false;

	void Start(){
		levelManager = FindObjectOfType <LevelManager> ();
	}
	void Awake () {
		alive = true;
	}
	void FixedUpdate () {
		transform.Translate (Vector3.up * Time.deltaTime * speed);
		if (Input.GetKey(KeyCode.LeftArrow) || leftTurnBool == true) {
			LefTurn ();
		}
		if (Input.GetKey(KeyCode.RightArrow) || rightTurnBool == true) {
			rightTurn ();
		}
		if (Input.GetKey (KeyCode.UpArrow) || accelerateBool == true) {
			Accelerate ();
		}
		Vector3 clampedPos = new Vector3 (Mathf.Clamp (transform.position.x, -3, 3), Mathf.Clamp (transform.position.y, -5, 5));
		transform.position = clampedPos;
	}
	void OnTriggerEnter2D(Collider2D col){
		alive = false;
		levelManager.LoadNextLevel ();
		Destroy (gameObject);
	}
	public void rightTurn(){
		transform.Rotate (0, 0, -2 - turnSpeed);
	}
	public void LefTurn(){
		transform.Rotate (0, 0, 2 + turnSpeed);
	}
	public void Accelerate(){
		speed += 0.1f;
		turnSpeed += 0.1f;
	}
	//arrow right turn scrip
	public void RightTurnTrue(){
		rightTurnBool = true;
	}
	public void RightTurnFalse(){
		rightTurnBool = false;
	}
	//arrow left turn scrip 
	public void LeftTurnTrue(){
		leftTurnBool = true;
	}
	public void LeftTurnFalse(){
		leftTurnBool = false;
	}
	//arrow accelerate script
	public void AccelerateTrue(){
		accelerateBool = true;
	}
	public void AccelerateFalse(){
		accelerateBool = false;
	}
}
