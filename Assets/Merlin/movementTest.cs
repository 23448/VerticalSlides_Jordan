﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementTest : MonoBehaviour {
	new private Rigidbody2D rigidbody;
	public float jumpPower = 3f;
	public float walkPower = 3f;
	float currentWalkSpeed = 0f;
	bool maxSpeed = false;
	bool jumpStart = false;
	bool jumping;
	bool canJump;
	float jumpStartTimer;
	bool walkDirection = false;
	float jumpTimer;




	void Start() {
		rigidbody = GetComponent<Rigidbody2D>();
		canJump = true;


	}
	void Update () {
		Jump ();

		if (!jumpStart) 
		{
		Walk (); 
		}
	}




	void Jump () {
		
		if(Input.GetKeyDown(KeyCode.Space) && canJump) 
		{
			jumpStartTimer = 0.3f;
			jumpStart = true;
			jumpTimer = 2f;

			Debug.Log ("why not work");

		}
		if (jumpTimer > 0) 
		{
			jumpTimer -= Time.deltaTime;
		}

		if (jumpStart) 
		{
			jumpStartTimer -= Time.deltaTime;
			Debug.Log ("why not work2");
		}

		if (jumpStartTimer < 0 && canJump && walkDirection) 
		{
			canJump = false;
			Debug.Log ("why not work3");
			jumpStart = false;
			jumping = true;
			rigidbody.velocity = new Vector2 (jumpPower / 3, jumpPower / 2);

		} 
		else if (jumpStartTimer < 0 && canJump && !walkDirection) 
		{
			canJump = false;
			Debug.Log ("why not work3");
			jumpStart = false;
			jumping = true;
			rigidbody.velocity = new Vector2 (-jumpPower / 3, jumpPower / 2);
		}
		if (jumpTimer <= 0) 
		{
			canJump = true;
			jumping = false;
			jumpStartTimer = 0.3f;
			jumpTimer = 2f;
		}

	}

	void Walk () {


		if (currentWalkSpeed <= walkPower && !maxSpeed) {

			currentWalkSpeed += walkPower / 13;
		}
		if (currentWalkSpeed >= walkPower) {

			maxSpeed = true;

		}
		if (maxSpeed && currentWalkSpeed >= 0) {

			currentWalkSpeed -= walkPower / 9;

		}
		if (currentWalkSpeed <= 0) {

			maxSpeed = false;
		}

		if (Input.GetKey (KeyCode.A)) {

			rigidbody.velocity = new Vector2 (-currentWalkSpeed, rigidbody.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
			walkDirection = false;

		}
		if (Input.GetKey (KeyCode.D)) {

			rigidbody.velocity = new Vector2 (currentWalkSpeed, rigidbody.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
			walkDirection = true;
		}
	}
}
