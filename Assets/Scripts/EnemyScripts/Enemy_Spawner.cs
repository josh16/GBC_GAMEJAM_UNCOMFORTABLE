using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour {

	//4 Spawners in the world
	public Transform spawnPoint;

	//Enemy Spawner Number
	public GameObject enemy;

	//Array for enemies
	//public int[] enemies;


	public float spawnRate; // How fast the enemies spawn





	//public bool isSpawning;


	// Use this for initialization
	void Start () {

		StartCoroutine ("spawnCounter");

	}
	
	// Update is called once per frame
	void Update () {



	}



	void Awake()
	{
		
	}



	//Spawn Counter
	IEnumerator spawnCounter()
	{



		while (true) //Since this is always "True" enemies will continue to spawn
		{
			yield return new WaitForSeconds (spawnRate);



				//Instantiating the Enemy in the spawner
				//Instantiate(enemy,spawnPoint.position,spawnPoint.rotation);

				



		}



	}


}
