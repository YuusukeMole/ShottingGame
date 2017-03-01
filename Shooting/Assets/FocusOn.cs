using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusOn : MonoBehaviour 
{
	public GameObject player;
	private Vector2 destination;

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			destination = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}

		player.transform.rotation = Quaternion.FromToRotation (Vector3.left, destination);
	}

}
