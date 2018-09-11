using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject enemy;
    float roundX;
    Vector2 whereTospawn;
    public float spawnRate = 2f;
    float nextspawn = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager0.gamehasended == false)
        {

            if (Time.time > nextspawn)
            {

                nextspawn = Time.time + spawnRate;
                roundX = Random.Range(-2, 2);
                whereTospawn = new Vector2(roundX, transform.position.y);
                Instantiate(enemy, whereTospawn, Quaternion.identity);
                //

            }
        }


    }
}
