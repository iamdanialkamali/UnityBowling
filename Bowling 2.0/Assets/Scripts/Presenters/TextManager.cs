using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour, EventListener
{
    public Text text ;
    private int point = 0;
    public BallModel.PlayerData playerData = new BallModel.PlayerData();

    private void Start()
    {
        ServiceLocator.Instance.eventManager.Register(this);

    }

    public void setup(BallModel.PlayerData data)
    {
        playerData = data;
        point = data.point;
    }


    public void OnEvent(GameEvent gameEvent)
    {
        text.gameObject.SetActive(true);
        point+= gameEvent.number;
        text.text = point.ToString();
        StartCoroutine(waiter());

    }
    IEnumerator waiter()
    {
        Debug.Log("WTFFFFFFFF");
        yield return new WaitForSecondsRealtime(4);
        text.gameObject.SetActive(false);
    }
}
