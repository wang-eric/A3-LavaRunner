using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour {

	public Text scoreLabel1;
	public Text scoreLabel2;
	private int score;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt("currentGameScore");
		this._SetScore ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	private void _SetScore() {

		if (score <= 1) {
			this.scoreLabel1.text = "and collected " + score + " chest";
			this.scoreLabel2.text = "and collected " + score + " chest";
		}
		else
		{
			this.scoreLabel1.text = "and collected " + score + " chests";
			this.scoreLabel2.text = "and collected " + score + " chests";
		}
		/*
		this.scoreLabel1.text = "and collected " + PlayerPrefs.GetInt("currentGameScore") + " chests";
		this.scoreLabel2.text = "and collected " + PlayerPrefs.GetInt("currentGameScore") + " chests";
		*/
	}

	// Restart Button Event Handler
	public void OnRestartButtonClick() {
		Application.LoadLevel ("Main");
	}
}
