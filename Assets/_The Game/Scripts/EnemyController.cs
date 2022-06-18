using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject playerPref;
    public float distanceFromTarget;

    private void Start()
    {
        playerPref = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        transform.position=Vector2.MoveTowards(transform.position,playerPref.transform.position,distanceFromTarget*Time.deltaTime);
        transform.right = playerPref.transform.position - transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            EnemyDeath();
        }
    }


    void EnemyDeath()
    {
        gameObject.SetActive(false);
    }
}
