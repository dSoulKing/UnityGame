using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Computer2 : MonoBehaviour {
    
    public GameObject allRepair;

    private Camera mainCamera;

    void OnMouseDown()
    {
        Debug.Log("PC2");
        if (GameController.boolComputer2 == true)
        {
            mainCamera = Camera.main;

            mainCamera.orthographicSize = 0.113f;
            mainCamera.transform.position = new Vector3(423.515f, 2.04f, -0.92f);
            mainCamera.transform.Rotate(-90, 0, 0);
            
            Instantiate(allRepair, allRepair.transform.position, allRepair.transform.rotation);
        }
    }
}