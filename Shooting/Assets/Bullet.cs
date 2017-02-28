using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	private float bulletlifetime = 0.5f;

	void Update()
	{
		bulletlifetime -= Time.deltaTime;
		if (bulletlifetime <= 0) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		GameObject other = collision.gameObject;
		if(other.layer== 8){
			Destroy(other.gameObject);
		}
	}

}
