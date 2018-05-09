using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_2g6 : MonoBehaviour {

    public GameObject thisCables;
    public Sprite spriteB;
    public Sprite spriteG;

    private SpriteRenderer spriteRenderer;
    private Vector3 petit;
    private Vector3 grand;
    private int randomRotation;

    void Start()
    {
        spriteRenderer = thisCables.GetComponent<SpriteRenderer>();

        randomRotation = Random.Range(1, 4);
        switch (randomRotation)
        {
            case 2:
                transform.Rotate(0, 0, -90);
                break;
            case 3:
                transform.Rotate(0, 0, -90);
                transform.Rotate(0, 0, -90);
                break;
            case 4:
                transform.Rotate(0, 0, -90);
                transform.Rotate(0, 0, -90);
                transform.Rotate(0, 0, -90);
                break;
        }
    }

    void Update()
    {
        if (transform.localEulerAngles.z == 90)
        {
            if (RepairManager.B_3g2)
            {
                spriteRenderer.sprite = spriteB;
                transform.localPosition = new Vector3(1.875f, 1.252f, 0);
                transform.localScale = new Vector3(1, 1, 1);

                RepairManager.B_2g6 = true;
            }
            else
            {
                spriteRenderer.sprite = spriteG;
                transform.localPosition = new Vector3(1.909f, 1.234f, 0);
                transform.localScale = new Vector3(1, 1, 1);
                RepairManager.B_2g6 = false;
            }
        }
        else
        {
            transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            spriteRenderer.sprite = spriteG;
            transform.localPosition = new Vector3(1.909f, 1.234f, 0);

            RepairManager.B_2g6 = false;
        }

    }

    private void OnMouseDown()
    {
        transform.Rotate(0, 0, -90);
    }
}
