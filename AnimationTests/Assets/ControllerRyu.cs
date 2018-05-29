using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRyu : MonoBehaviour {

    public static bool zangiefAttack = false;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (zangiefAttack)
        {
            animator.SetBool("ZangiefAttack", zangiefAttack);
            zangiefAttack = false;
        }
        else
            animator.SetBool("ZangiefAttack", zangiefAttack);

        

    }
}
