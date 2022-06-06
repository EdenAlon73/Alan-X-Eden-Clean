using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform leftspawn;

    public Transform rightspawn;

    public Transform topspawn;

    private float _timer = 1.2f;

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            SpawnEnemy();
        }
        
    }

    void SpawnEnemy()
    {

            int num = Random.Range(1, 4);

            switch (num)
            {
                case 1:

                   GameObject enemypref = ObjectPooler.SharedInstance.GetPooledObject();

                    if (enemypref != null)
                    {

                    enemypref.transform.position = leftspawn.position;

                    enemypref.SetActive(true);

                    }

             

                    break;


                case 2:

                enemypref = ObjectPooler.SharedInstance.GetPooledObject();

                if (enemypref != null)
                {
                    enemypref.transform.position = topspawn.position;

                  

                    enemypref.SetActive(true);
                }

                

                    

                    break;

                case 3:

                enemypref = ObjectPooler.SharedInstance.GetPooledObject();

                if (enemypref != null)

                {
                    enemypref.transform.position = rightspawn.position;

                    

                    enemypref.SetActive(true);
                }

                

                    

                    break;
            }

        _timer = 1.2f;
        
    }
}

