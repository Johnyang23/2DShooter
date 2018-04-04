/*
 * Name: John Yang
 * Student ID: 100941170
 * Last Coded: Oct 20, 2017
 * Description: Handles the airplane collision when in collides with an object.
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneCollision : MonoBehaviour {
	//Public varibles
	public GameObject explode;
	public GameController gameController;

	//Private varibles
	private AudioSource coinSound;

	// Use this for initialization
	void Start () {
		coinSound = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
	}

	//Method when object collides
	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag.Equals ("coin")) {
			Debug.Log ("Collision coin\n");
			//Plays the coin soud
			if (coinSound != null) {
				coinSound.Play ();
			}
			//Calls the reset fuction from the coin controller
			other.gameObject.
			GetComponent<CoinController> ()
				.Reset ();
			//Gets 100 points when the airplane collides with coin
			gameController.Score += 100;
		}
		else if (other.gameObject.tag.Equals ("meteor")) {
			Debug.Log ("Collision enemy\n");
			//Explosion animation
			Instantiate (explode)
				.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;
			// Calls the reset fuction from the Meteor Controller
			other.gameObject.
			GetComponent<MeteorController> ()
				.Reset ();
			//Loses a life when airplane collides with meteor
			gameController.Life -= 1;
		}
	}
}


