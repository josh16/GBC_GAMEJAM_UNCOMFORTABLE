using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour {

	//Health Variables
	public float maxHealth;
	public float currentHealth;
	private float dmg = 5;





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



	}




	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Spider") 
		{
			if (currentHealth <= maxHealth) 
			{
				currentHealth -= dmg;
			}

			if (currentHealth <= 0) 
			{
				Destroy (this.gameObject);

				//Disable player movement
				//Font pops up and says "Player is dead"
				//

			}
		}
	}

}
