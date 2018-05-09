﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof15Clicked : MonoBehaviour {

    public Camera mainCamera;
    public GameObject thisRoof;

    public static bool cam15;

    void Start()
    {
        mainCamera.gameObject.SetActive(true);
        mainCamera.orthographic = true;
        thisRoof.SetActive(true);
        cam15 = true;
    }

    void Update()
    {
        if (cam15 == false)
        {
            thisRoof.SetActive(false);
        }
        else if (cam15 == true)
        {
            thisRoof.SetActive(true);
        }
    }

    void OnMouseDown()
    {
        if (RoofsBool.cam == true)
        {
            mainCamera.orthographicSize = 2.2f;
            mainCamera.transform.position = new Vector3(17.49f, 5.3f, 10.95f);
            //mainCamera.rect = new Rect(2f, 5f, 1, 1);
            cam15 = false;
            RoofsBool.cam = false;
        }
        else if (RoofsBool.cam == false)
        {
            GameObject groundBackObject = GameObject.Find("GroundBack");
            GroundBack groundBack = groundBackObject.GetComponent<GroundBack>();
            groundBack.SetActiveAll();

            mainCamera.orthographicSize = 9.1f;
            mainCamera.transform.position = new Vector3(12, 2.9f, 9);

            RoofsBool.cam = true;

        }
    }
}
