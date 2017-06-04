using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	// enum to keep track of game state
	public enum AllGameStates
	{
		WAITING, INGAME, GAMEOVER, PAUSED, OTHER
	}
	public AllGameStates currGameState;


	// current score
	[HideInInspector]
	public int score;


	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {

		currGameState = AllGameStates.INGAME;
		
	}
	
	// Update is called once per frame
	void Update () {

		switch (currGameState)
		{
		case AllGameStates.WAITING:

			break;
		case AllGameStates.INGAME:

			score = (int)Time.timeSinceLevelLoad;
			UIManager.instance.UpdateScore(score);

			break;
		case AllGameStates.GAMEOVER:

			if(score > HighScore)
				HighScore = score;
			UIManager.instance.ShowGameOverScreen();

			currGameState = AllGameStates.OTHER;
			break;
		case AllGameStates.OTHER:

			break;

		}
		
	}

	// High score save/read 
	public static int HighScore
	{
		get {
			return PlayerPrefs.GetInt ("HighScore", 0);
		}
		set {
			PlayerPrefs.SetInt ("HighScore", value);
			PlayerPrefs.Save ();
		}
	}
}
