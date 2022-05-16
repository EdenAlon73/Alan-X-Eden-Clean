using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    private Animator _playerAnimator;

    private void Awake()
    {
        _playerRb = GetComponentInParent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_playerRb.velocity.y != 0)
        {
            _playerAnimator.SetBool("IsSpin", true);
        }
        else
        {
            _playerAnimator.SetBool("IsSpin", false);
        }
    }
    
    
}
