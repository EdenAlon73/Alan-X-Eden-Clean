using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform leftspawn;

    public Transform rightspawn;

    public Transform topspawn;

    public GameObject enemyToSpawn;

    private void Start()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {


        if (enemyToSpawn != null)
        {
            int num = Random.Range(1, 4);

            switch (num)
            {
                case 1:

                    enemyToSpawn.transform.position = leftspawn.position;

                    enemyToSpawn.SetActive(true);

                    break;

                case 2:

                    enemyToSpawn.transform.position = topspawn.position;

                    enemyToSpawn.SetActive(true);

                    break;

                case 3:

                    enemyToSpawn.transform.position = rightspawn.position;

                    enemyToSpawn.SetActive(true);

                    break;
            }


        }
    }
}

