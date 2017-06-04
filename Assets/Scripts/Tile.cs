using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public Transform myEndPoint;

	private bool nextTileCreated = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(GameManager.instance.currGameState == GameManager.AllGameStates.INGAME)
		transform.Translate(Vector2.down * LevelGenerator.instance.tileMoveSpeed * Time.deltaTime);

		if(nextTileCreated == false && myEndPoint.position.y < LevelGenerator.instance.yPositionToGenerate)
		{
			nextTileCreated = true;
			LevelGenerator.instance.GenerateNextTile(myEndPoint);
		}

		if(myEndPoint.position.y < LevelGenerator.instance.yPositionToDestroy)
			Destroy(gameObject);
		
	}
}
