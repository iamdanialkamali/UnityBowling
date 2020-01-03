using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainGameManager : MonoBehaviour
{
	public GameObject gameCamera;
	public GameObject mainCamera;
	
	private GameObject _cylinders;
	private GameObject _reserveCylinders;
	private GameObject _ball;
	private bool _isStopped;
	private Rigidbody ballRigidbody;
	private Text _text;
	private GameObject _canvas;
	private bool _waiting;
	Rigidbody[] currentCylinders;

	private Transform[] cylindersTransforms;
	// Use this for initialization
	void Start ()
	{
		_isStopped = false;
		_cylinders = GameObject.Find("Cylinders");
		_reserveCylinders = Instantiate(_cylinders);
		_reserveCylinders.SetActive(false);
		_ball = GameObject.Find("Ball");
		ballRigidbody = _ball.GetComponent<Rigidbody>();
		_canvas = GameObject.Find("Canvas");
		_text = _canvas.GetComponentInChildren<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (_isStopped == false)
		{
			if (ballRigidbody.velocity[1] < -10)
			{
				if (_waiting == false)
				{
					StartCoroutine(waiter());
				}
			}

			cylinderManager();
		}

		if (Input.GetKeyDown(KeyCode.Q))
		{
			if (Time.timeScale ==0)
			{
				gameCamera.SetActive(true);
				mainCamera.SetActive(false);
				
				Time.timeScale = 1;
				_isStopped = false;
			}else{
				
				gameCamera.SetActive(false);
				mainCamera.SetActive(true);
				Time.timeScale = 0;
				_isStopped = true;

				
			}
		}
		
	}

	void cylinderManager()
	{
		currentCylinders =  _cylinders.gameObject.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody cylinder in currentCylinders)
		{
			if ((cylinder.transform.rotation[0] != 0 || cylinder.transform.rotation[1] != 0 ||
			    cylinder.transform.rotation[2] != 0 ))
			{
//				cylinder.gameObject.transform.position [0] = cylinder.gameObject.transform[0]
				if ((cylinder.velocity[1]) > 0.5)
				{
					float yVel = (float) (cylinder.velocity[1] * 1.2);

					if (yVel > 0)
					{
						yVel = -yVel;
					}

					cylinder.velocity =
						new Vector3((float) (cylinder.velocity[0]), yVel, (float) (cylinder.velocity[2]));
				}

//				cylinder.gameObject.transform.ve(Vector3.down * 100 * Time.deltaTime);
			}
		}
	}
	IEnumerator waiter()
	{
		_waiting = true;
		int cnt = 0;
//			gameCylinders = _cylinders.GetComponents<>();
		cylindersTransforms = _cylinders.GetComponentsInChildren<Transform>();
		Debug.Log(currentCylinders.Length.ToString());
		yield return new WaitForSecondsRealtime(4);
		foreach (Transform cylindersTransform in cylindersTransforms )
		{
			if (
				cylindersTransform.rotation[0] >0.2 ||
				cylindersTransform.rotation[0] <-0.2 ||
				cylindersTransform.rotation[1] >0.2 ||
				cylindersTransform.rotation[1] <-.2 ||
				cylindersTransform.rotation[2] >0.2 ||
				cylindersTransform.rotation[2] <-0.2 )
			{
				Debug.Log(cylindersTransform.transform.rotation.ToString());

				cnt++;
			}
			else
			{
				Debug.Log("No"+cylindersTransform.transform.rotation.ToString());

			}

		}
		ballRigidbody.position = new Vector3(0,-2,-120);
		ballRigidbody.velocity = new Vector3(0,0,0);

		if (cnt == 10)
		{
			_text.text = "Spray";

		}
		else
		{
			_text.text = "Score:" + cnt.ToString();
		}

		_text.gameObject.SetActive(true);
		GameObject.Destroy(_cylinders);
		_cylinders = Instantiate(_reserveCylinders);
		_cylinders.SetActive(true);

		yield return new WaitForSecondsRealtime(4);
		
		_text.gameObject.SetActive(false);
		_waiting = false;

	}
}
