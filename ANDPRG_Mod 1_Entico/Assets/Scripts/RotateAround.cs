using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateAround : MonoBehaviour
{
	//Referenced from an online script

	public Transform planet;
	public int speed;

	void Start()
	{
		if (planet == null)
		{
			planet = this.gameObject.transform;
			Debug.Log("RotateAround target not specified. Defaulting to parent GameObject");
		}
	}

	void Update()
	{
		transform.RotateAround(planet.transform.position, planet.transform.up, speed * Time.deltaTime);
	}
}