using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : MonoBehaviour
{
    public bool _waiting;

    public void stopGame()
    {
        Time.timeScale = 0;
    }
    
    public void resumeGame()
    {
        Time.timeScale = 1;
    }

    public bool isStoped()
    {
        return Math.Abs(Time.timeScale - 1) < 0.1;
    }
    
    public void setIsWaiting(bool state)
    {
        _waiting = state;
    }
    
    

    public bool getIsWaiting()
    {
        return _waiting;
    }
    
    
}
