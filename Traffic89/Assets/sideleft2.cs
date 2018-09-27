using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideleft2 : MonoBehaviour {
    
    public GameObject enemy1;
    float roundX1;
    Vector2 whereTospawn1;
    public float spawnRate1 = 3f;
    float nextspawn1 = 0.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {

            if (Time.time > nextspawn1)
            {

                nextspawn1 = Time.time + spawnRate1;
                roundX1 = Random.Range(-2.55f, -2.55f);
                whereTospawn1 = new Vector2(roundX1, transform.position.y);
                Instantiate(enemy1, whereTospawn1, Quaternion.identity);
            }
        }
    }
}
