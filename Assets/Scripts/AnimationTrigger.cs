// for triggering animatioin inside each tiles

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour {

	// Name of animation to play in animator
	public string animName;


	// starts animation after triggering a collision with this object
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			transform.parent.GetComponent<Animator>().enabled = true;
			transform.parent.GetComponent<Animator>().Play(animName);

		}

	}
}
