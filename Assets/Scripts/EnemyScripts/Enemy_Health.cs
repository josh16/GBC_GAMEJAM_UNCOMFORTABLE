using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour {

	public float maxHealth = 100;
	public float currentHealth = 100;
	private float dmg = 20f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	//Collision with Bullet
	void OnTriggerEnter(Collider other)
	{
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
	}
}
