using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainCamera;
    public void PlayGame()
    {
        mainCamera.SetActive(false);
        Time.timeScale = 1;

    }

    private void Update()
    {
//        if (Input.GetKey(KeyCode.Q))
//        {
//            if (Time.timeScale ==0)
//            {
//                mainCamera.SetActive(false);
//                Time.timeScale = 1;
//
//            }else{
//				
//                mainCamera.SetActive(true);
//                Time.timeScale = 0;
//				
//            }
//        }
    }
}
