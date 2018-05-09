using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_5g1 : MonoBehaviour {

    public GameObject thisCables;
    public Sprite spriteR;
    public Sprite spriteG;

    private SpriteRenderer spriteRenderer;
    private Vector3 petit;
    private Vector3 grand;
    private int randomRotation;
    private double angle;

    void Start()
    {
        spriteRenderer = thisCables.GetComponent<SpriteRenderer>();

        randomRotation = Random.Range(1, 4);
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
    }

    void Update()
    {
        if (angle == 245.5)
        {
            
            spriteRenderer.sprite = spriteR;
            transform.localPosition = new Vector3(-0.05274f, 0.06948f, 0);
            transform.localScale = new Vector3(0.0284f, 0.0284f, 0.0284f);

            RepairManager.R_5g1 = true;
        }
        else
        {
            transform.localScale = new Vector3(0.016f, 0.016f, 0.016f);
            spriteRenderer.sprite = spriteG;
            transform.localPosition = new Vector3(-0.05387878f, 0.06818771f, 0);

            RepairManager.R_5g1 = false;
        }

    }

    private void OnMouseDown()
    {
        transform.Rotate(0, 0, -90);
        angle = transform.localEulerAngles.z;
    }
}
