/*
 * Name: John Yang
 * Student ID: 100941170
 * Last Coded: Oct 20, 2017
 * Description: Handles coin movement.
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	//Public variables
	[SerializeField]
	private float speed = 1f;
	[SerializeField]
	private float startY = 4;
	[SerializeField]
	private float endY = -4;
	[SerializeField]
	private float startX = 12;
	[SerializeField]
	private float endX = -12;

	//Private variables
	private Transform transform;
	private Vector2 currentPos;

	// Use this for initialization
	void Start () {
		transform = gameObject.GetComponent<Transform> ();
		currentPos = transform.position;
		Reset ();
	}

	// Update is called once per frame
	void Update () {
		currentPos = transform.position;
		//Move coin to the left
		currentPos -= new Vector2 (speed, 0);
		//Check if we need to reset
		if (currentPos.x < endX) {
			//Calls the reset function
			Reset ();
		}
		//Apply changes
		transform.position = currentPos;
	}

	//Reset function
	public void Reset(){
		float y = Random.Range (-4, 4);
		currentPos = new Vector2 (12, y);
		transform.position = currentPos;
	}
}



