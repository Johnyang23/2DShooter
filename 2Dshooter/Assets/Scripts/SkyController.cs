/*
 * Name: John Yang
 * Student ID: 100941170
 * Last Coded: Oct 20, 2017
 * Description: Handles background movement.
 */ 
using UnityEngine;
using System.Collections;

public class SkyController : MonoBehaviour {

	//Public variables
	[SerializeField]
	private float speed = 0.05f; //slow speed for moving background

	//Private variables
	private Transform transform = null;
	private Vector2 currentPosition ;

	//Private constants variables 
	private const float startPosition = 29f;
	private const float resetPosition = -28f;

	//Use this for initialization
	void Start () {
		transform = gameObject.transform;
		currentPosition = transform.position;
		//Reset the position
		Reset ();
	}

	//Update is called once per frame
	void Update () {
		//Scrolling background
		currentPosition = transform.position;
		currentPosition -= new Vector2(speed, 0);
		transform.position = currentPosition;
		//If the x cordinate of the background passes -28f, it calls the reset function 
		if (gameObject.transform.position.x < resetPosition)
			Reset ();
	}

	//Reset backgorund
	public void Reset(){
		currentPosition = new Vector2(startPosition, 0);
		transform.position = currentPosition;
	}
}
