using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
	private GameObject _camera;
	private Rigidbody _ballRigidbody;
	Rigidbody _cameraTransform;
	// Use this for initialization
	void Start ()
	{	
		_ballRigidbody = GameObject.Find("Ball").GetComponent<Rigidbody>();
		_cameraTransform = this.gameObject.GetComponent<Rigidbody>();
	}
	
	void Update () {
		setPosition();
	}

	private void setPosition()
	{
		if (_ballRigidbody.position[2] < -60)
		{
			_cameraTransform.position = _ballRigidbody.position + new Vector3(0, +30, -35);
		}
		else
		{
			if (_cameraTransform.position[1] <30)
			{
				_cameraTransform.position +=  new Vector3(0, (float) 0.2, 0);
			}
		}
	}
}
