using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform leftspawn;

    public Transform rightspawn;

    public Transform topspawn;

    public Transform lefttopspawn;

    public Transform righttopspawn;

    public Transform bottomspawn;

    public Transform bottomrightspawn;

    public Transform bottomleftspawn;

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

            int num = Random.Range(1, 9);

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


            case 4:

                enemypref = ObjectPooler.SharedInstance.GetPooledObject();

                if (enemypref != null)

                {
                    enemypref.transform.position = bottomspawn.position;



                    enemypref.SetActive(true);
                }





                break;


            case 5:

                enemypref = ObjectPooler.SharedInstance.GetPooledObject();

                if (enemypref != null)

                {
                    enemypref.transform.position = bottomleftspawn.position;



                    enemypref.SetActive(true);
                }





                break;


            case 6:

                enemypref = ObjectPooler.SharedInstance.GetPooledObject();

                if (enemypref != null)

                {
                    enemypref.transform.position = bottomrightspawn.position;



                    enemypref.SetActive(true);
                }





                break;


            case 7:

                enemypref = ObjectPooler.SharedInstance.GetPooledObject();

                if (enemypref != null)

                {
                    enemypref.transform.position = righttopspawn.position;



                    enemypref.SetActive(true);
                }





                break;


            case 8:

                enemypref = ObjectPooler.SharedInstance.GetPooledObject();

                if (enemypref != null)

                {
                    enemypref.transform.position = lefttopspawn.position;



                    enemypref.SetActive(true);
                }



                break;




        }

        _timer = 1.2f;
        
    }
}

