using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follow_Player : MonoBehaviour {


	public float chaseSpeed;
	public float rotSpeed;

	public Transform player;

	NavMeshAgent agent;



	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Awake () {

		player = GameObject.FindGameObjectWithTag ("Player").transform; //Find the Gameobject with the correct tag name
		agent = GetComponent<NavMeshAgent> ();
		agent.SetDestination (player.position); //= player.position;

		//We want the agent to stop within a range of the player


	}

	void Update()
	{
		agent.SetDestination (player.position);

	}

}
