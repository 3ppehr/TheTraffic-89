using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject kale;
    float roundX;
    float roundX1;
    Vector2 whereTospawn;
    Vector2 whereTospawn1;
    public float spawnRate = 2f;
    public float spawnRate1 = 2f;
    float nextspawn = 0.0f;
    float nextspawn1 = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {

            if (Time.time > nextspawn)
            {

                nextspawn = Time.time + spawnRate;
                roundX = Random.Range(-2, 2);
                whereTospawn = new Vector2(roundX, transform.position.y);
                Instantiate(enemy, whereTospawn, Quaternion.identity);




                nextspawn1 = Time.time + spawnRate1;
                roundX1 = Random.Range(-2, 2);
                whereTospawn1 = new Vector2(roundX1, transform.position.y);
                Instantiate(kale, whereTospawn1, Quaternion.identity);


            }



            //if (Time.time > nextspawn1)
            //{

            //    nextspawn1 = Time.time + spawnRate1;
            //    roundX = Random.Range(-2, 2);
            //    whereTospawn1 = new Vector2(roundX1, transform.position.y);
            //    Instantiate(kale, whereTospawn, Quaternion.identity);


            //}
        }


    }
}
