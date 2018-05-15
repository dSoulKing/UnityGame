using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject worker1;
    public GameObject worker2;
    public GameObject worker3;
    public GameObject helpBubble;
    public GameObject exclamationPoint1;
    public GameObject exclamationPoint2;
    public GameObject clickToSetUp1;

    public static bool boolComputer1;
    public static bool boolComputer2;

    private Vector3 positionWorker;
    private Vector3 positionExclamationPoint;
    private Vector3 positionHelpBubble;

    private float timeNewWorker;
    private float timeNewHelp;
    private int numberWorker;
    private int numberExclamationPoint;
    
    

    void Start()
    {
        timeNewWorker = 5f;
        timeNewHelp = 15f;

        numberWorker = 0;
        numberExclamationPoint = 0;

        positionWorker = new Vector3(8.699707f, 4.293945f, 11.82227f);
        positionExclamationPoint = new Vector3(1.5f, 2.22f, 7);
        positionHelpBubble = new Vector3(1.735f, 1, 8.752f);

        boolComputer1 = false;
        boolComputer2 = false;
    }

    void Update()
    {
        if (MenuStart.begin)
        {
            timeNewWorker -= Time.deltaTime;
            timeNewHelp -= Time.deltaTime;
        }

        if (timeNewWorker <= 0)
        {
            numberWorker++;
            if (numberWorker == 1)
            {
                Instantiate(worker1, positionWorker, Quaternion.identity);
                timeNewWorker = 25f;

                Instantiate(clickToSetUp1, clickToSetUp1.transform.position, clickToSetUp1.transform.rotation);
            }
            else if (numberWorker == 2)
            {
                Instantiate(worker2, positionWorker, Quaternion.identity);
                timeNewWorker = 15f;
            }
            else if (numberWorker == 3)
            {
                Instantiate(worker3, positionWorker, Quaternion.identity);
                timeNewWorker = 5000f;
            }
        }

        if (timeNewHelp <= 0)
        {
            numberExclamationPoint++;
            if (numberExclamationPoint == 1)
            {
                exclamationPoint1 = (GameObject) Instantiate(exclamationPoint1, positionExclamationPoint, exclamationPoint1.transform.rotation);
                Instantiate(helpBubble, positionHelpBubble, helpBubble.transform.rotation);

                timeNewHelp = 20f;
                positionExclamationPoint = new Vector3(22.5f, 2.22f, 10.5f);
                positionHelpBubble = new Vector3(23.725f, 1, 10.814f);

                boolComputer1 = true;
            }
            else if (numberExclamationPoint == 2)
            {
                exclamationPoint2 = (GameObject) Instantiate(exclamationPoint2, positionExclamationPoint, exclamationPoint2.transform.rotation);
                Instantiate(helpBubble, positionHelpBubble, helpBubble.transform.rotation);

                timeNewHelp = 20f;
                positionExclamationPoint = new Vector3(7f, 2.22f, 1.5f);
                
                boolComputer2 = true;
            }
        }
    }

}
