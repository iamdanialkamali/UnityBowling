using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
	private GameObject _camera;
	private Rigidbody _ballRigidbody;
	Rigidbody _cameraRigidBody;
	// Use this for initialization
	void Start ()
	{	
		_ballRigidbody = GameObject.Find("Ball").GetComponent<Rigidbody>();
		Debug.Log("BALLL"+_ballRigidbody.name);
		_cameraRigidBody = GetComponent<Rigidbody>();
		Debug.Log("Camera"+_cameraRigidBody.name);
		_camera = GameObject.Find("GameCamera");
//		var transformRotation = _camera.transform.rotation;
//		transformRotation[1] = 0;
//		transformRotation[2] = 0;
	}
	
	// Update is called once per frame
	void Update () {
		setPosition();
	}

	void setPosition()
	{
		if (_ballRigidbody.position[2] < -60)
		{
			_cameraRigidBody.position = _ballRigidbody.position + new Vector3(0, +10, -15);
			
			
		}
		else
		{
			if (_cameraRigidBody.position[1] <30)
			{
				_cameraRigidBody.position +=  new Vector3(0, (float) 0.2, 0);
			}
		}
	}
}
