using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour {

	//4 Spawners in the world
	public Transform spawnPoint;

	//Enemy Spawner Number
	public GameObject enemy;


	//Lists for enemies
	public List<GameObject> Enemies = new List<GameObject>();


	public float spawnRate; // How fast the enemies spawn





	//public bool isSpawning;


	// Use this for initialization
	void Start () {

		Enemies.Capacity = 10;


		StartCoroutine ("spawnCounter");

	}
	
	// Update is called once per frame
	void Update () {


	}




	//Spawn Counter
	IEnumerator spawnCounter()
	{
		for (int i = 0; Enemies.Capacity <= 10; i++)
		{

			yield return new WaitForSeconds (spawnRate);

			//Instantiating the Enemy in the spawner
			spawnEnemies();

			Enemies.Remove (enemy); // Remove enemy from list

		}



		//while (true) //Since this is always "True" enemies will continue to spawn
		//{
		//	yield return new WaitForSeconds (spawnRate);
				
				//Instantiating the Enemy in the spawner
		//		Instantiate(enemy,spawnPoint.position,spawnPoint.rotation);

		//}

	

	}



	void spawnEnemies()
	{
		Instantiate(enemy,spawnPoint.position,spawnPoint.rotation);
	}


}
