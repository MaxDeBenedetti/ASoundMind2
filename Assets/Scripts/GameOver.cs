using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public TextMesh scoreText, highScoreText;
	private int score, highScore;
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt("score");
		highScore = PlayerPrefs.GetInt("highScore");
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
		highScoreText.text = "High Score: " + highScore;
	}
}
