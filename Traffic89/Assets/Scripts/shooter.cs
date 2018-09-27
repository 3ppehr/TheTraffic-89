using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {
    public GameObject bullet;
    public ScoringSystem scoringscript;
    // Use this for initialization
    void Start () {
        scoringscript = GameObject.Find("Main Camera").GetComponent<ScoringSystem>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter2D(Collision2D col2)
    {
        if (col2.gameObject.tag == "Enemy")
        {
            Debug.Log("first step");
             scoringscript._score();
             Destroy(col2.gameObject);

        }


        if (col2.gameObject.tag == "crash car")
        {
            Destroy(bullet);

        }
        else
        {
            Destroy(bullet);
        }
    }
    }
