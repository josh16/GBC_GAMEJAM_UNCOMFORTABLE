using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Controller : MonoBehaviour {

	public bool isFiring;


	//Reference to Bullet_Controller script 
	public Bullet_Controller bullet;
	public float bulletSpeed;

	public float timeBetweenShots;
	private float shootingCounter;

	public Transform firePointSpawner;





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		//Condition for firing bullets
		if (isFiring) {
			shootingCounter -= Time.deltaTime;

			if (shootingCounter <= 0) {
				shootingCounter = timeBetweenShots; //Reset the shooting of bullets
				Bullet_Controller newBullet = Instantiate (bullet, firePointSpawner.position, firePointSpawner.rotation) as Bullet_Controller;
			
				newBullet.Speed = bulletSpeed; // Set the gameObjects speed
			
			}
		} else {
			shootingCounter = 0; // Set the counter back to zero
		}

	}
}
