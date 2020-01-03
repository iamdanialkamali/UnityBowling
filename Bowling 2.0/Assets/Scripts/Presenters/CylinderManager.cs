using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CylinderManager : MonoBehaviour
{
    
    Rigidbody[] currentCylinders;
    private int dead;
    public GameConfig GameConfig;
    
    private Transform[] cylindersTransforms;
    // Start is called before the first frame update
    void Start()
    {
        cylindersTransforms = this.GetComponentsInChildren<Transform>();
        currentCylinders =  this.gameObject.GetComponentsInChildren<Rigidbody>();

    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void countFellDowns()
    {
        StartCoroutine(waiter());
    }

    public bool isFinish()
    {
//        Debug.Log(dead);
        return dead == currentCylinders.Length;
    }




    public IEnumerator  waiter()
    {
        int cnt = 0;
        yield return new WaitForSecondsRealtime(GameConfig.waitngTime);
        foreach (Rigidbody cylindersTransform in currentCylinders )
        {
            
            if (
                cylindersTransform.transform.rotation[0] > 0.5 ||
                cylindersTransform.transform.rotation[0] < -0.5 ||
                cylindersTransform.transform.rotation[1] > 0.5 ||
                cylindersTransform.transform.rotation[1] < -0.5 ||
                cylindersTransform.transform.rotation[2] > 0.5 ||
                cylindersTransform.transform.rotation[2] < -0.5)
            {
                if (cylindersTransform.gameObject.active)
                {
                    dead++;
                    cnt++;
                    cylindersTransform.transform.Fade();
                }   
                cylindersTransform.gameObject.SetActive(false);
            }
        

        }

        if (cnt == 10)
        {
            ServiceLocator.Instance.eventManager.Propagate(new GameEvent(GameConfig.sprayPoint));
        }
        else
        {
//            ServiceLocator.Instance.eventManager.Propagate(new GameEvent(GameConfig.sprayPoint * cnt));
            ServiceLocator.Instance.eventManager.Propagate(new GameEvent(GameConfig.perPinPoint * cnt));
        }
    }
}
