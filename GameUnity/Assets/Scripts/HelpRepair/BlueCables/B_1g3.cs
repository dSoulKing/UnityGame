using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_1g3 : MonoBehaviour {

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
    }

    void Update()
    {
        if (transform.localEulerAngles.z == 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            spriteRenderer.sprite = spriteB;
            transform.localPosition = new Vector3(0.092f, 0.038f, 0);
            
            RepairManager.B_1g3 = true;
        }
        else
        {
            transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            spriteRenderer.sprite = spriteG;
            transform.localPosition = new Vector3(0, 0, 0);
            
            RepairManager.B_1g3 = false;
        }
        
    }

    private void OnMouseDown()
    {
        transform.Rotate(0, 0, 90);
    }

}
