using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour {

	public float maxHealth = 100;
	public float currentHealth = 100;
	private float dmg = 20f;

	public GameObject greenDeathFire;
	public Transform particleSpawner;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	//Collision with Bullet
	void OnTriggerEnter(Collider other)
	{
		//Colliding with Bullet
		if (other.gameObject.tag == "Bullet")
		{
			if (currentHealth <= maxHealth) 
			{
				Debug.Log ("Im hit!");
				currentHealth -= dmg;
			}

			if(currentHealth <= 0)
			{
				Destroy (this.gameObject);
			}
		
		}
	
		//Colliding with Player
		if (other.gameObject.tag == "Player") 
		{
			Destroy (this.gameObject);
			Debug.Log ("Touched player!");

			//Instantiate/Invoke particle effect
			Instantiate(greenDeathFire, particleSpawner.position,particleSpawner.rotation);
			StartCoroutine ("particleTimer");


			

		}
	}



	IEnumerator particleTimer()
	{
		yield return new WaitForSeconds(4);
		Destroy (greenDeathFire);
		Debug.Log ("Paticle system turning off!");
	}
	

}
