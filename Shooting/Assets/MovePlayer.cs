using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour 
{
	private Vector2 destination;
	private float movespeed = 3.0f;

	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			destination = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}

		transform.position = Vector2.MoveTowards (transform.position, new Vector2 (destination.x, destination.y), movespeed * Time.deltaTime);
	}
}
