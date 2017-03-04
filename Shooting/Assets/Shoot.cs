using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour 
{
	public Rigidbody BarrelPrefub;
	public Transform BarrelTransForm;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.S)){
			Rigidbody rocketbarrel;
			rocketbarrel = Instantiate (BarrelPrefub, BarrelTransForm.position, BarrelTransForm.rotation)as Rigidbody;
			rocketbarrel.AddForce (BarrelTransForm.up * 500);
		}
	}
}
