/*
 * Name: John Yang
 * Student ID: 100941170
 * Last Coded: Oct 20, 2017
 * Description: Handles game navigation.
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	[SerializeField]
	Text lifeLabel;
	[SerializeField]
	Text scoreLabel;
	[SerializeField]
	Text gameOverLabel;
	[SerializeField]
	Text highScoreLabel;
	[SerializeField]
	Button resetBtn;
	//Private variables
	private int _score = 0;
	private int _life = 3;

	public int Score{
		get{ return _score; }
		set{ 
			_score = value;
			scoreLabel.text = "Score: " + _score;
			highScoreLabel.text = "Score: " + _score;
		}

	}

	public int Life{
		get{ return _life; }
		set{ 
			_life = value;
			if (_life <= 0) {
				//Calls the gameOver function
				gameOver();
			}else{
				lifeLabel.text = "Life: " + _life;
			}
		}
	}
	//initialize function
	private void initialize(){
		Score = 0;
		Life = 3;
		//Setting the label to invisiable
		gameOverLabel.gameObject.SetActive (false);
		highScoreLabel.gameObject.SetActive (false);
		resetBtn.gameObject.SetActive (false);
		//Setting the label to visiable
		lifeLabel.gameObject.SetActive (true);
		scoreLabel.gameObject.SetActive (true);
		Time.timeScale = 1;
	}

	//gameOver function
	private void gameOver(){
		//Setting the label to invisiable
		gameOverLabel.gameObject.SetActive (true);
		highScoreLabel.gameObject.SetActive (true);
		resetBtn.gameObject.SetActive (true);
		//Setting the label to visiable
		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
		Time.timeScale = 0;
	}

	// Use this for initialization
	void Start () {
		//Calls the initialize fuction
		initialize ();
	}

	// Update is called once per frame
	void Update () {
	}

	//Event handler when reset buttons is clicked, the game restarts
	public void ResetBtnClick(){
		SceneManager.
		LoadScene (
			SceneManager.GetActiveScene ().name);
	}
}
