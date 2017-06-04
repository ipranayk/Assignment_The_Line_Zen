// tile movement

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

		// move tile only if game state is INGAME else stop
		if(GameManager.instance.currGameState == GameManager.AllGameStates.INGAME)
		transform.Translate(Vector2.down * LevelGenerator.instance.tileMoveSpeed * Time.deltaTime);

		// if this tile moves below a y position, create new tile from level generator
		if(nextTileCreated == false && myEndPoint.position.y < LevelGenerator.instance.yPositionToGenerate)
		{
			nextTileCreated = true;
			LevelGenerator.instance.GenerateNextTile(myEndPoint);
		}


		// destroy this tile
		if(myEndPoint.position.y < LevelGenerator.instance.yPositionToDestroy)
			Destroy(gameObject);
		
	}
}
