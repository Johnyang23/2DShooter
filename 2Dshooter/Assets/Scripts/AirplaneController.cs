/*
 * Name: John Yang
 * Student ID: 100941170
 * Last Coded: Oct 20, 2017
 * Description: Handles player movement.
 */ 
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AirplaneController : MonoBehaviour {
	//Public variable
	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Player movement input
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		//Direction of input
		Vector2 direction = new Vector2 (inputX, inputY).normalized;
		//Function to move player
		Move (direction);
	}

	//function for the character to freely move within the boundaries
	void Move(Vector2 direction)
	{
		//Bottom-left and top-right camera bounds
		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
		//Setting the max and min player's boundery 
		max.x = max.x - 1.4f;
		min.x = min.x + 1.4f;
		max.y = max.y - 0.8f;
		min.y = min.y + 0.8f;
		//Airplane movement
		Vector2 position = transform.position;
		position += direction * speed * Time.deltaTime;
		//Checking the boundary  
		position.x = Mathf.Clamp(position.x, min.x, max.x);
		position.y = Mathf.Clamp(position.y, min.y, max.y);
		//Move player to camera bounds
		transform.position = position;
	}
}

		

