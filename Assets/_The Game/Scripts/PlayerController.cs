using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
   //Variable Fields
   [Header("Player Stats")]
   [SerializeField]private float jumpValue = 7f;
   [SerializeField]private float horizontalValue = 3f;
   [SerializeField]private float fallMultiplier = 2.5f;
   [SerializeField]private float lowJumpMultiplier = 2f;
   private int flipJumpDir = -1;
   
   //Components Cache:
   private Rigidbody2D _rigidbody2D;
    
       private void Awake()
       {
          _rigidbody2D = GetComponent<Rigidbody2D>();
       }
    
       private void Update()
       {
          if (Input.GetButtonDown("Jump"))
          {
             _rigidbody2D.velocity = (Vector2.up * jumpValue) + (Vector2.left * horizontalValue);
             horizontalValue *= flipJumpDir; 
          }
          
          if (_rigidbody2D.velocity.y < 0)
          {
             _rigidbody2D.velocity += Vector2.up * (Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime);
          }
          else if (_rigidbody2D.velocity.y>0&&!Input.GetButton("Jump"))
          {
             _rigidbody2D.velocity += Vector2.up * (Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime);
          }
       }
}

