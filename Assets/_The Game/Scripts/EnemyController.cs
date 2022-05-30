using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public PlayerController playerController;

    public float mindistancefromtarget;


    void Update()
    {

        transform.position=Vector2.MoveTowards(transform.position,playerController.transform.position,mindistancefromtarget*Time.deltaTime);

        transform.right = playerController.transform.position - transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) EnemyDeath();
    }


    void EnemyDeath()
    {
        gameObject.SetActive(false);
    }
}
