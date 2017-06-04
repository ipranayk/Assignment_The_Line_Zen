using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public static UIManager instance;

	// game over panel 
	public GameObject gameOverPanel;


	// high score and score texts at game end
	public Text highScoreText;
	public Text currScoreText;

	// live score text
	public Text scoreText;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// shows game over screen
	public void ShowGameOverScreen()
	{
		gameOverPanel.SetActive(true);
		highScoreText.text = GameManager.HighScore.ToString();
		currScoreText.text = GameManager.instance.score.ToString();
	}

	// restart game on game over
	public void RestartGame()
	{
		SceneManager.LoadScene("Game");
	}

	// shows live score at top left of screen while playing
	public void UpdateScore(int score)
	{
		scoreText.text = score.ToString();
	}


}
