using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

	//Health Variables
	public float maxHealth;
	public float currentHealth;
	private float dmg = 5.0f;	
	private float healthUp = 5.0f;

	public Slider healthBarSlider; // reference to slider on player

	//Level name 
	public string levelName;


	// Update is called once per frame
	void Update () {

	}



	void OnTriggerEnter(Collider other)
	{
		//Colliding with Spider
		if (other.gameObject.tag == "Spider") 
		{
			if (currentHealth <= maxHealth) 
			{
				currentHealth -= dmg;
				healthBarSlider.value -= 0.05f;
			}

			if (currentHealth <= 0) 
			{
				StartCoroutine ("deathDelay");
				Application.LoadLevel (levelName);
			



				//Disable player movement
				//Font pops up and says "Player is dead"
				//

			}
		
		}
	
		//Colliding with HealthPack pickup
		if(other.gameObject.tag == "HealthPack")
		{

			Debug.Log ("CRASHED INTO HEALTH PICKUP");

			if (currentHealth < maxHealth) 
			{
				currentHealth += healthUp;
				healthBarSlider.value += 0.05f;

			}
		}


	}



	IEnumerator deathDelay ()
	{

		yield return new WaitForSeconds (2f);
		Destroy (this.gameObject);

	}

}
