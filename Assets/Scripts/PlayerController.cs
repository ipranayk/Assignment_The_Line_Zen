// player movement 

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// player move sensitivity ( speed )
	public float moveSpeed;


	// for mouse delta movement
	private Vector3 delta  = Vector3.zero;
	private Vector3 lastPos = Vector3.zero;

	// player rigidbody
	private Rigidbody2D playerRigid;


	void Start()
	{
		playerRigid = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if ( Input.GetMouseButtonDown(0) )
		{
			lastPos = Input.mousePosition;
		}
		else if ( Input.GetMouseButton(0) )
		{
			delta = Input.mousePosition - lastPos;

			lastPos = Input.mousePosition;
		}

		else if ( Input.GetMouseButtonUp(0) )
		{
			delta = Vector3.zero;
		}

		// player movement
		playerRigid.AddForce(Vector2.right * delta.x * moveSpeed * Time.deltaTime);
	}

	// detect collisiion for game over
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Death")
		{
			print("Game Over!");
			GameManager.instance.currGameState = GameManager.AllGameStates.GAMEOVER;
		}
	}
}