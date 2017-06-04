using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public static LevelGenerator instance;

	public float tileMoveSpeed = 1.0f;

	public GameObject[] allTiles;

	// below this y co ordinate, new tile will instantiate
	public float yPositionToGenerate;

	// below this y co ordinate, a tile will get destroyed
	public float yPositionToDestroy;

	// to keep track of last generated tile ( not to repeate same tile again )
	private int lastTileNumber = 0;


	void Awake()
	{
		instance = this;
	}


	public void GenerateNextTile(Transform origin)
	{
		// select random tile from tile array
		int ranTileNumber = Random.Range(0, allTiles.Length);


		// not to repeat same tile twice back to back
		while (ranTileNumber == lastTileNumber)
		{
			ranTileNumber = Random.Range(0, allTiles.Length);
		}

		// create new tile
		Instantiate(allTiles[ranTileNumber], origin.position, Quaternion.identity);
	}
}
