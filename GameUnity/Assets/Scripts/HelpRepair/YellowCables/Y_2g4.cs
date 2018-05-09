﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_2g4 : MonoBehaviour {

    public GameObject thisCables;
    public Sprite spriteY;
    public Sprite spriteG;

    private SpriteRenderer spriteRenderer;
    private Vector3 petit;
    private Vector3 grand;
    private int randomRotation;
    private double angle;

    void Start()
    {
        spriteRenderer = thisCables.GetComponent<SpriteRenderer>();

        randomRotation = UnityEngine.Random.Range(1, 4);
        switch (randomRotation)
        {
            case 2:
                transform.Rotate(0, 0, 90);
                break;
            case 3:
                transform.Rotate(0, 0, 90);
                transform.Rotate(0, 0, 90);
                break;
            case 4:
                transform.Rotate(0, 0, 90);
                transform.Rotate(0, 0, 90);
                transform.Rotate(0, 0, 90);
                break;
        }

        angle = transform.localEulerAngles.z;
        angle = Math.Round(angle, 1);
    }

    void Update()
    {
        if (angle == 65.5)
        {
            if (RepairManager.Y_5g2)
            {
                spriteRenderer.sprite = spriteY;
                transform.localPosition = new Vector3(-0.06988f, -0.01657f, 0);
                transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);

                RepairManager.Y_2g4 = true;
            }
            else
            {
                spriteRenderer.sprite = spriteG;
                transform.localPosition = new Vector3(-0.07097459f, -0.01595211f, 0);
                transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
                RepairManager.Y_2g4 = false;
            }
        }
        else
        {
            transform.localScale = new Vector3(0.016f, 0.016f, 0.016f);
            spriteRenderer.sprite = spriteG;
            transform.localPosition = new Vector3(-0.07097459f, -0.01595211f, 0);

            RepairManager.Y_2g4 = false;
        }

    }

    private void OnMouseDown()
    {
        transform.Rotate(0, 0, -90);
        angle = transform.localEulerAngles.z;
        angle = Math.Round(angle, 1);
        //Debug.Log(angle);
    }
}