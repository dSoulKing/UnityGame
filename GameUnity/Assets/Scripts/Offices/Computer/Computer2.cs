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

            mainCamera.orthographicSize = 9.3f;
            mainCamera.transform.position = new Vector3(464.2f, 1.6f, 9);
            mainCamera.transform.Rotate(-90, 0, 0);
            
            Instantiate(allRepair, allRepair.transform.position, allRepair.transform.rotation);
        }
    }
}