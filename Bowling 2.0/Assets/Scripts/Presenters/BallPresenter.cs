using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BallPresenter : MonoBehaviour,EventListener
{
    // Start is called before the first frame update
    private Rigidbody _ballRigidbody;
    private BallModel _ballModel;
    public BallConfig _ballConfig;
    public GameConfig _gameConfig;
    BallModel.PlayerData playerData =  new BallModel.PlayerData();
    
    private float _force;
    // Use this for initialization
    private void Awake()
    {
       
    }

    public void OnEvent(GameEvent gameEvent)
    {
        playerData.point += gameEvent.number;
        string jsonString = JsonUtility.ToJson(playerData);
        PlayerPrefs.SetString("myData", jsonString);

    }

    void Start () {
        ServiceLocator.Instance.eventManager.Register(this);
        string loadString = PlayerPrefs.GetString("myData");
        playerData = JsonUtility.FromJson<BallModel.PlayerData>(loadString);
        
        _ballRigidbody = GameObject.Find("Ball").GetComponent<Rigidbody>();
        _force = _ballConfig.force;
        GameObject.Find("Text").GetComponent<TextManager>().setup(playerData);
    }

    public void setup(BallModel model)
    {
        _ballModel = model;
    }

    public bool isFalling()
    {
        return _ballModel.isFalling();
    }

    public void resetPosition()
    {
        
        StartCoroutine(waiter());

    }
    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(_gameConfig.waitngTime);
        _ballModel.setPosition(_ballConfig.initialPosition);
        GameObject.Find("BallFire").GetComponent<ParticleSystem>().DORestart();

    }    
    
    void Update ()
    {
        if (_ballRigidbody.position[2] < _gameConfig.planedLine_Z) 
        {
            ManageInput();
        }
        else
        {
            if (!_ballModel.moving)
            {
                transform.DOMove(_ballRigidbody.velocity + transform.position.normalized*2, _gameConfig.ballMoveDuration).SetEase(Ease.Linear);
                _ballModel.moving = true;
            }
        }
    }
    void ManageInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _ballRigidbody.AddForce(new Vector3(0,0,_force));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _ballRigidbody.AddForce(new Vector3(_force,0,0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _ballRigidbody.AddForce(new Vector3(-_force,0,10));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _ballRigidbody.AddForce(new Vector3(0,0,-_force));
        }
    }
    
}
