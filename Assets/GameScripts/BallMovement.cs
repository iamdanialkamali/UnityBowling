using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallMovement : MonoBehaviour
{
	private GameObject ball;
	private GameObject _plane;
	private Rigidbody ballRigidbody;

	private int _force = 25000;
	// Use this for initialization
	void Start () {
		ball =  GameObject.Find("Ball");
		ballRigidbody = ball.GetComponent<Rigidbody>();
		_plane = GameObject.Find("StartPlane");
		Rigidbody plane = _plane.GetComponent<Rigidbody>();

	}




	// Update is called once per frame
	void Update ()
	{
		if (ballRigidbody.position[2] < -60)
		{
			ManageInput();
			
		}

	}

//	Collision
	private void OnCollisionStay(Collision other)
	{
		if (other.gameObject.name == "StartPlane")
		{
			
			ManageInput();
		}
	}private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "StartPlane")
		{
			
			ManageInput();
		}
	}private void OnCollisionExit(Collision other)
	{
		if (other.gameObject.name == "StartPlane")
		{
			
			ManageInput();
		}
	}

	void ManageInput()
	{
		
		if (Input.GetKey(KeyCode.UpArrow))
		{
			Debug.Log(
				"UUUUUUUUUUUUUUUUUUUUpppp");
			ballRigidbody.AddForce(new Vector3(0,0,_force));
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			ballRigidbody.AddForce(new Vector3(_force,0,0));
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			ballRigidbody.AddForce(new Vector3(-_force,0,10));
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			ballRigidbody.AddForce(new Vector3(0,0,-_force));
		}
	}
}
