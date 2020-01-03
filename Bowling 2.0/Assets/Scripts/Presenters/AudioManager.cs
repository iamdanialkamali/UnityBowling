using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource sound;

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name.Contains("Cylinder"))
		{
			sound.Play();
		}
	}
}


