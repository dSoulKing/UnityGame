using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairManager : MonoBehaviour {

    public GameObject parent;
    public GameObject computerCore;

    public GameObject electricPowerBlue;

    public GameObject electricPowerB1;
    public GameObject electricPowerB2;
    public GameObject electricPowerB3;
    public GameObject electricPowerB4;
    public GameObject electricPowerB5;
    public GameObject electricPowerB6;
    public GameObject electricPowerB7;
    public GameObject electricPowerB8;
    public GameObject electricPowerB9;
    public GameObject electricPowerB10;
    public GameObject electricPowerB11;
    public GameObject electricPowerB12;
    public GameObject electricPowerB13;
    public GameObject electricPowerB14;
    public GameObject electricPowerB15;
    public GameObject electricPowerB16;
    public GameObject electricPowerB17;

    public GameObject electricPowerR1;
    public GameObject electricPowerR2;
    public GameObject electricPowerR3;
    public GameObject electricPowerR4;
    public GameObject electricPowerR5;
    public GameObject electricPowerR6;
    public GameObject electricPowerR7;
    public GameObject electricPowerR8;
    public GameObject electricPowerR9;
    public GameObject electricPowerR10;
    public GameObject electricPowerR11;
    public GameObject electricPowerR12;
    public GameObject electricPowerR13;
    public GameObject electricPowerR14;
    public GameObject electricPowerR15;
    public GameObject electricPowerR16;
    public GameObject electricPowerR17;

    public GameObject electricPowerY1;
    public GameObject electricPowerY2;
    public GameObject electricPowerY3;
    public GameObject electricPowerY4;
    public GameObject electricPowerY5;
    public GameObject electricPowerY6;
    public GameObject electricPowerY7;
    public GameObject electricPowerY8;
    public GameObject electricPowerY9;
    public GameObject electricPowerY10;
    public GameObject electricPowerY11;
    public GameObject electricPowerY12;
    public GameObject electricPowerY13;
    public GameObject electricPowerY14;
    public GameObject electricPowerY15;
    public GameObject electricPowerY16;
    public GameObject electricPowerY17;

    public GameObject electricPowerG1;
    public GameObject electricPowerG2;
    public GameObject electricPowerG3;
    public GameObject electricPowerG4;
    public GameObject electricPowerG5;
    public GameObject electricPowerG6;
    public GameObject electricPowerG7;
    public GameObject electricPowerG8;
    public GameObject electricPowerG9;
    public GameObject electricPowerG10;
    public GameObject electricPowerG11;
    public GameObject electricPowerG12;
    public GameObject electricPowerG13;

    public static bool B_1g1;
    public static bool B_1g2;
    public static bool B_1g3;
    public static bool B_2g1;
    public static bool B_2g2;
    public static bool B_2g3;
    public static bool B_2g4;
    public static bool B_2g5;
    public static bool B_2g6;
    public static bool B_3g1;
    public static bool B_3g2;
    public static bool B_7g1;

    public static bool R_1g1;
    public static bool R_1g2;
    public static bool R_2g1;
    public static bool R_2g2;
    public static bool R_2g3;
    public static bool R_2g4;
    public static bool R_2g5;
    public static bool R_2g6;
    public static bool R_5g1;
    public static bool R_6g1;
    
    public static bool Y_2g1;
    public static bool Y_2g2;
    public static bool Y_2g3;
    public static bool Y_2g4;
    public static bool Y_4g1;
    public static bool Y_4g2;
    public static bool Y_5g1;
    public static bool Y_5g2;
    public static bool Y_8g1;

    public static bool G_1g1;
    public static bool G_1g2;
    public static bool G_2g1;
    public static bool G_2g2;
    public static bool G_2g3;
    public static bool G_2g4;

    //public static bool repairStart;

    private GameObject[] electricPowerBTab;
    private GameObject[] electricPowerRTab;
    private GameObject[] electricPowerYTab;
    private GameObject[] electricPowerGTab;
    private float electricTimeB;
    private float electricTimeR;
    private float electricTimeY;
    private float electricTimeG;
    private int i;
    private int y;
    private int w;
    private int z;

    private void Start()
    {
        Instantiate(electricPowerBlue, electricPowerBlue.transform.position, electricPowerBlue.transform.rotation);

        B_1g1 = false;
        B_1g2 = false;
        B_1g3 = false;
        B_2g1 = false;
        B_2g2 = false;
        B_2g3 = false;
        B_2g4 = false;
        B_2g5 = false;
        B_2g6 = false;
        B_3g1 = false;
        B_3g2 = false;
        B_7g1 = false;

        R_1g1 = false;
        R_1g2 = false;
        R_2g1 = false;
        R_2g2 = false;
        R_2g3 = false;
        R_2g4 = false;
        R_2g5 = false;
        R_2g6 = false;
        R_5g1 = false;
        R_6g1 = false;

        Y_2g1 = false;
        Y_2g2 = false;
        Y_2g3 = false;
        Y_2g4 = false;
        Y_4g1 = false;
        Y_4g2 = false;
        Y_5g1 = false;
        Y_5g2 = false;
        Y_8g1 = false;

        G_1g1 = false;
        G_1g2 = false;
        G_2g1 = false;
        G_2g2 = false;
        G_2g3 = false;
        G_2g4 = false;

        electricPowerBTab = new GameObject[] {electricPowerB1,
                                              electricPowerB2,
                                              electricPowerB3,
                                              electricPowerB4,
                                              electricPowerB5,
                                              electricPowerB6,
                                              electricPowerB7,
                                              electricPowerB8,
                                              electricPowerB9,
                                              electricPowerB10,
                                              electricPowerB11,
                                              electricPowerB12,
                                              electricPowerB13,
                                              electricPowerB14,
                                              electricPowerB15,
                                              electricPowerB16,
                                              electricPowerB17};

        electricPowerRTab = new GameObject[] {electricPowerR1,
                                              electricPowerR2,
                                              electricPowerR3,
                                              electricPowerR4,
                                              electricPowerR5,
                                              electricPowerR6,
                                              electricPowerR7,
                                              electricPowerR8,
                                              electricPowerR9,
                                              electricPowerR10,
                                              electricPowerR11,
                                              electricPowerR12,
                                              electricPowerR13,
                                              electricPowerR14,
                                              electricPowerR15,
                                              electricPowerR16,
                                              electricPowerR17};

        electricPowerYTab = new GameObject[] {electricPowerY1,
                                              electricPowerY2,
                                              electricPowerY3,
                                              electricPowerY4,
                                              electricPowerY5,
                                              electricPowerY6,
                                              electricPowerY7,
                                              electricPowerY8,
                                              electricPowerY9,
                                              electricPowerY10,
                                              electricPowerY11,
                                              electricPowerY12,
                                              electricPowerY13,
                                              electricPowerY14,
                                              electricPowerY15,
                                              electricPowerY16,
                                              electricPowerY17};

        electricPowerGTab = new GameObject[] {electricPowerG1,
                                              electricPowerG2,
                                              electricPowerG3,
                                              electricPowerG4,
                                              electricPowerG5,
                                              electricPowerG6,
                                              electricPowerG7,
                                              electricPowerG8,
                                              electricPowerG9,
                                              electricPowerG10,
                                              electricPowerG11,
                                              electricPowerG12,
                                              electricPowerG13};

        i = 0;
        y = 0;
        w = 0;
        z = 0;
        electricTimeB = 1f;
        electricTimeR = 1f;
        electricTimeY = 1f;
        electricTimeG = 1f;
    }

    private void Update()
    {

        if (B_7g1)
        {

            Debug.Log("electricBlue true");
            electricTimeB -= Time.deltaTime;

            if (electricTimeB <= 0 && i < 17)
            {
                Debug.Log("electricBlue time");
                electricPowerBlue.transform.GetChild(i).gameObject.SetActive(true);
                //electricPowerBTab[i].SetActive(true);
                i++;
                electricTimeB = 0.5f;
            }
        }

        if (R_1g1)
        {
            electricTimeR -= Time.deltaTime;
            if (electricTimeR <= 0 && y < 17)
            {
                electricPowerRTab[y].SetActive(true);
                y++;
                electricTimeR = 0.5f;
            }
        }

        if (Y_2g1)
        {
            electricTimeY -= Time.deltaTime;
            if (electricTimeY <= 0 && w < 17)
            {
                electricPowerYTab[w].SetActive(true);
                w++;
                electricTimeY = 0.5f;
            }
        }

        if (G_1g1)
        {
            electricTimeG -= Time.deltaTime;
            if (electricTimeG <= 0 && z < 13)
            {
                electricPowerGTab[z].SetActive(true);
                z++;
                electricTimeG = 0.5f;
            }
        }

        if (i == 17 && y == 17 && w == 17 && z == 13)
        {
            computerCore.SetActive(true);
        }
    }
}
