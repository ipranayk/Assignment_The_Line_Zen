using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public static UIManager instance;

	public GameObject gameOverPanel;

	public Text highScoreText;
	public Text currScoreText;

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

	public void ShowGameOverScreen()
	{
		gameOverPanel.SetActive(true);
		highScoreText.text = GameManager.HighScore.ToString();
		currScoreText.text = GameManager.instance.score.ToString();
	}

	public void RestartGame()
	{
		SceneManager.LoadScene("Game");
	}

	public void UpdateScore(int score)
	{
		scoreText.text = score.ToString();
	}


}
