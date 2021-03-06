﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour {

	private float speed = 5;
	public static int damage = 1;

	// Update is called once per frame
	void Update () {

		Vector3 bulletPos = transform.position;

		bulletPos = new Vector3 (bulletPos.x - speed * Time.deltaTime, bulletPos.y, 1);

		transform.position = bulletPos;

		Vector3 max = new Vector3 (-10f, 4.4f, 1);

		if (transform.position.x < max.x) {

			Destroy (gameObject);
		}
		
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		//all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
		if(col.tag == "Player" || col.tag == "Meteor" || col.tag == "Bullet")
		{
			Destroy(gameObject);
		}
	}
}
