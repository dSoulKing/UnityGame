using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearUser : MonoBehaviour {

    public GameObject thisCircle;
    public Sprite blueCircle;
    public Sprite whiteCircle;

    public static bool nearCircle = false;
    public static bool setActiveCircle = true;
    public static Vector3 positionCircle;

    private void Start()
    {
        positionCircle = thisCircle.transform.position;
    }

    private void Update()
    {
        if (!setActiveCircle)
            Destroy(thisCircle);
        /*thisCircle.SetActive(setActiveCircle);
    else
        thisCircle.SetActive(false);*/
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == GameObject.Find("User"))
        {
            thisCircle.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 0, 1f);
            nearCircle = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == GameObject.Find("User"))
        {
            thisCircle.GetComponent<SpriteRenderer>().color = new Color(1f, 0, 0, 1f);
            nearCircle = false;
        }
    }
}
