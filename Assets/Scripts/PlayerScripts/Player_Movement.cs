using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	//Public variables
	public float movementSpeed;
	private Rigidbody rbody;


	//Reference to Player_Health script
	//public Player_Health myHealth;


	//Reference to Weapon_Controller script
	public Weapon_Controller thePlayersGun;



	//Input Variables
	private Vector3 movementInput; 
	private Vector3 movementVelocity;


	public Camera mainCamera;

	//Controller input
	public bool useController;


	// Use this for initialization
	void Start () {

		rbody = GetComponent<Rigidbody> ();
		mainCamera = FindObjectOfType<Camera> ();


	}
	
	// Update is called once per frame
	void Update () {

		movementInput = new Vector3(Input.GetAxisRaw("Horizontal"),0f,Input.GetAxisRaw("Vertical")); //Getting 

		movementVelocity = movementInput * movementSpeed; // The velocity is the movement speed * by the input

		//RayCasting

		Ray cameraRay = mainCamera.ScreenPointToRay (Input.mousePosition);
		Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
		float rayLength;

		//If statement for RayCasting
		if (groundPlane.Raycast (cameraRay, out rayLength)) 
		{
			Vector3 pointToLook = cameraRay.GetPoint(rayLength);
			Debug.DrawLine (cameraRay.origin, pointToLook, Color.red); //Debug to test out to see ray
		
			//Player to look at point where mouse cursor points at
			transform.LookAt(new Vector3(pointToLook.x,transform.position.y,pointToLook.z));

		}


		//(**** KEYBOARD/MOUSE ****)
		if (Input.GetMouseButtonDown (0)) //Holding down button fires bullets
		{
			thePlayersGun.isFiring = true;
		}

		if (Input.GetMouseButtonUp (0)) // Once button is released, bullets stop firing
		{
			thePlayersGun.isFiring = false; 
		}



	}




	void FixedUpdate() {

		rbody.velocity = movementVelocity; //Rigidbody velocity becomes the set velocity in update




	}







}
