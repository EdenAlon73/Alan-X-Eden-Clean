using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private Animator playerAnimator;

    private void Awake()
    {
        playerRb = GetComponentInParent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        Debug.Log(playerRb.velocity.y);
        if (playerRb.velocity.y != 0)
        {
            playerAnimator.SetBool("IsSpin", true);
        }
        else
        {
            playerAnimator.SetBool("IsSpin", false);
        }
    }
    
    
}
