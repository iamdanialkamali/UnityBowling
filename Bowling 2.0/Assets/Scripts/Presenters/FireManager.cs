using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform _ballTransform;

    // Use this for initialization
    void Start ()
    {
        _ballTransform = GameObject.Find("Ball").GetComponent<Transform>();
    }
	
    void Update () {
        setPosition();
    }

    private void setPosition()
    {
        this.transform.position = _ballTransform.position;
    }
}
