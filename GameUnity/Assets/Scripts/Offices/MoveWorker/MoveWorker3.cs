using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWorker3 : MonoBehaviour
{

    public GameObject workerMove1;
    public GameObject workerMove2;
    public SpriteRenderer spriteWorker1;
    public SpriteRenderer spriteWorker2;
    public Sprite bigHead;
    public GameObject clickToSetUp3;

    public GameObject warning;

    public GameObject sphere0;
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;
    public GameObject sphere7;
    public GameObject sphere8;
    public GameObject sphere9;
    public GameObject sphere10;
    public GameObject sphere11;
    public GameObject sphere12;
    public GameObject sphere13;
    public GameObject finalSit;

    private GameObject[] spheres;
    private int i;
    private float timeToMove;
    private float timeToTilt;

    void Start()
    {
        i = 0;
        timeToMove = 4f;
        timeToTilt = 0f;
        spheres = new GameObject[] {sphere0,
                                    sphere1,
                                    sphere2,
                                    sphere3,
                                    sphere4,
                                    sphere5,
                                    sphere6,
                                    sphere7,
                                    sphere8,
                                    sphere9,
                                    sphere10,
                                    sphere11,
                                    sphere12,
                                    sphere13,
                                    finalSit};

        workerMove1.SetActive(false);
        workerMove1.transform.Rotate(0, -90, 0, Space.World);
        workerMove2.transform.Rotate(0, -90, 0, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        timeToMove -= Time.deltaTime;

        if (timeToMove <= 0 && i < spheres.Length)
        {
            if (i == 8)
            {
                workerMove1.transform.Rotate(0, 90, 0, Space.World);
                workerMove2.transform.Rotate(0, 90, 0, Space.World);
            }
            else if (i == 9)
            {
                spriteWorker1.sprite = bigHead;
                spriteWorker2.sprite = bigHead;
                Instantiate(clickToSetUp3, clickToSetUp3.transform.position, clickToSetUp3.transform.rotation);
            }
            else if (i == 10)
            {
                workerMove1.transform.Rotate(0, -90, 0, Space.World);
                workerMove2.transform.Rotate(0, -90, 0, Space.World);
            }
            else if (i == 12)
            {
                workerMove1.transform.Rotate(0, 90, 0, Space.World);
                workerMove2.transform.Rotate(0, 90, 0, Space.World);
            }
            else if (i == 13)
            {
                workerMove1.transform.Rotate(0, 90, 0, Space.World);
                workerMove2.transform.Rotate(0, 90, 0, Space.World);
            }
            else if (i == 14)
            {
                workerMove1.transform.Rotate(0, 90, 0, Space.World);
                workerMove2.transform.Rotate(0, 90, 0, Space.World);
            }

            if (i % 2 == 0)
            {
                workerMove1.SetActive(true);
                workerMove1.transform.position = spheres[i].transform.position;
                Destroy(spheres[i]);
                workerMove2.SetActive(false);
                timeToMove = 4f;
            }
            else if (i % 2 == 1)
            {
                workerMove2.SetActive(true);
                workerMove2.transform.position = spheres[i].transform.position;
                Destroy(spheres[i]);
                workerMove1.SetActive(false);
                timeToMove = 4f;
            }
            i++;
        }

        if (i == spheres.Length && GameController.boolSetUp3)
        {
            timeToTilt -= Time.deltaTime;
            if (timeToTilt <= 0)
            {
                GameController.malus++;
                timeToTilt = 5f;
            }
            warning.SetActive(true);
        }
        else
            warning.SetActive(false);
    }
}

