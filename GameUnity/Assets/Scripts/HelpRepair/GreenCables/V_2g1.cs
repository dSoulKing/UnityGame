﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_2g1 : MonoBehaviour {

    public GameObject thisCables;
    public Sprite spriteV;
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
        if (angle == 335.5)
        {
            if (RepairManager.G_2g2)
            {
                spriteRenderer.sprite = spriteV;
                transform.localPosition = new Vector3(0.03365f, -0.05845f, 0);
                transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);

                RepairManager.G_2g1 = true;
            }
            else
            {
                spriteRenderer.sprite = spriteG;
                transform.localPosition = new Vector3(0.03330624f, -0.05860424f, 0);
                transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);

                RepairManager.G_2g1 = false;
            }
        }
        else
        {
            transform.localScale = new Vector3(0.016f, 0.016f, 0.016f);
            spriteRenderer.sprite = spriteG;
            transform.localPosition = new Vector3(0.03330624f, -0.05860424f, 0);

            RepairManager.G_2g1 = false;
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
