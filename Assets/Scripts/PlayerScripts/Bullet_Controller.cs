using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour {

	public float Speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//moving the bullet in a vector 3 forward position
		transform.Translate (Vector3.forward * Speed * Time.deltaTime);
		Destroy (this.gameObject, 3);




	}


	void OnTiggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Spider") 
		{
			Destroy (this.gameObject);

			// ***** WORK IN PROGRESS *****
		}

	}

	//Collision on walls, enemies, objects to destroy this bullet
	void OnCollisionEnter(Collision collision)
	{
		Destroy (this.gameObject);
	}

}
