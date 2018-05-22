using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TongueMenu : MonoBehaviour, IPointerDownHandler {

    public GameObject image;

    private Animator animator;
    private bool isOpen = false;

    private void Start()
    {
        animator = image.GetComponent<Animator>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isOpen = !isOpen;
        Debug.Log(isOpen);
        animator.SetBool("isOpen", isOpen);
        GameController.gamePause = !GameController.gamePause;
    }
}
