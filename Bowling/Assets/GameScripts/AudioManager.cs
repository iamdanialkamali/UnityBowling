using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource sound;
	// Use this for initialization
	void Start () {
		
	}

		
	

	
	private void OnCollisionEnter(Collision other)
	{
//		Debug.Log(other.gameObject.name.ToString());
		if (other.gameObject.name.Contains("Cylinder"))
		{
			sound.Play();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
