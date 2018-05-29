using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerZangief : MonoBehaviour {
    

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
            animator.SetTrigger("clickToAttack");
            ControllerRyu.zangiefAttack = true;

    }
}
