using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public static LevelGenerator instance;

	public float tileMoveSpeed = 1.0f;

	public GameObject[] allTiles;

	public float yPositionToGenerate;
	public float yPositionToDestroy;

	private int lastTileNumber = 0;


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

	public void GenerateNextTile(Transform origin)
	{
		int ranTileNumber = Random.Range(0, allTiles.Length);


		// not to repeat same tile twice back to back
		while (ranTileNumber == lastTileNumber)
		{
			ranTileNumber = Random.Range(0, allTiles.Length);
		}


		Instantiate(allTiles[ranTileNumber], origin.position, Quaternion.identity);
	}
}
