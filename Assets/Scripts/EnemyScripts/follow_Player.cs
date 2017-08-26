using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_Player : MonoBehaviour {


	public float chaseSpeed;
	//public float rotSpeed;

	public Transform player;

	//private Rigidbody rb;



	// Use this for initialization
	void Start () {
		//brb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 toTarget = player.position - transform.position;

		transform.Translate (toTarget * chaseSpeed * Time.deltaTime);

	}
}
