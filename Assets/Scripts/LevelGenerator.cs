using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public static LevelGenerator instance;

	public float tileMoveSpeed = 1.0f;

	public GameObject[] allTiles;

	public float yPositionToGenerate;
	public float yPositionToDestroy;


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
		Instantiate(allTiles[Random.Range(0, allTiles.Length)], origin.position, Quaternion.identity);
	}
}
