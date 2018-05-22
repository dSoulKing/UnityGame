﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Computer2 : MonoBehaviour {
    
    public GameObject allRepair;

    private Camera mainCamera;

    void OnMouseDown()
    {
        GameObject gameControllerObject = GameObject.Find("GameController");
        GameController gameController = gameControllerObject.GetComponent<GameController>();

        Debug.Log("PC2");
        if (GameController.boolComputer2 == true)
        {
            Destroy(gameController.exclamationPoint1);
            Roof5Clicked.eP2 = false;

            mainCamera = Camera.main;

            mainCamera.orthographicSize = 9.3f;
            mainCamera.transform.position = new Vector3(464.2f, 1.6f, 9);
            mainCamera.transform.Rotate(-90, 0, 0);
            
            Instantiate(allRepair, allRepair.transform.position, allRepair.transform.rotation);

            GameController.gamePause = true;
        }
    }
}