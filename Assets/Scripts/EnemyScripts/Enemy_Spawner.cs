using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour {

	//4 Spawners in the world
	public Transform spawnPoint;

	//Enemy Spawner Number
	public GameObject enemy;


	//Lists for keeping track on the amount of Enemies
	public List<GameObject> Enemies = new List<GameObject>();



	// How fast the enemies spawn
	public float spawnRate; 

	public string levelName;



	public bool isSpawning;


	// Use this for initialization
	void Start () {

	//Amount of Enemies remaining
	
		isSpawning = true;


		Enemies.Capacity = 50;


		StartCoroutine ("spawnCounter");

	}
	
	// Update is called once per frame
	void Update () {


	}



	//Spawn Counter
	IEnumerator spawnCounter()
	{
		for (int i = 0; Enemies.Capacity <= 50; i++)
		{

			yield return new WaitForSeconds (spawnRate);

			//Instantiating the Enemy in the spawner
			spawnEnemies();

			Enemies.Remove (enemy); // Remove enemy from list

			if (Enemies.Count == 0) 
			{
				isSpawning = false;
				Application.LoadLevel (levelName);
			}

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
		
		//Enemies will only spawn as long as this boolean is set to true
		if (isSpawning == true) 
		{
			Instantiate(enemy,spawnPoint.position,spawnPoint.rotation);
		}

	}





	/*
	void spawnEnemies(int count)
	{
		for (int i = 0; i < count; i++) 
		{
			Enemies.Add(GameObject.Instantiate(enemy, spawnPoint.position, spawnPoint.rotation));
		}
		//Instantiate(enemy,spawnPoint.position,spawnPoint.rotation);

	}



	void allDead()
	{
		if (Enemies.Contains (enemy)) 
		{
			Enemies.Remove (enemy);
			if (Enemies.Count == 0) 
			{
				Debug.Log("no more enemies!");
			}
		}
	}

	
	
*/

}
