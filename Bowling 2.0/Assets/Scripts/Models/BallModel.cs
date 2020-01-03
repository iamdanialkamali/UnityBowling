using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallModel : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject _ball;
    Rigidbody _ballRigidbody;
    public bool moving = false;

    [System.Serializable]
    public class PlayerData
    {
        public int point = 0;
    }

    public void setup(GameObject ball)
    {
        _ball = ball;
        _ballRigidbody = _ball.GetComponent<Rigidbody>();
    }  
    public Rigidbody getRigidbody()
    {
        return _ballRigidbody;
    }
    public GameObject getBall()
    {
        return _ball;
    }

    public bool isFalling()
    {
        return _ballRigidbody.velocity[1] < -100 && _ballRigidbody.position.y < -30  ;
    }

    public void setPosition(Vector3 position)
    {
        _ballRigidbody.velocity = Vector3.zero;
        _ballRigidbody.position = position;
        moving = false;
    }
}
