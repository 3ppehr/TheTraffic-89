using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
  //  public ScoringSystem Scoring;
    public GameObject bullet;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    //void OnCollisionEnter2D(Collision2D col2)
    //{
    //    if (col2.gameObject.tag == "Enemy")
    //    {
    //        Debug.Log("first step");
    //        float tmpscore= GetComponent<ScoringSystem>().myScore;
    //        Debug.Log("step 2");
    //        GetComponent<ScoringSystem>().myScore = tmpscore + 100;
    //        Debug.Log("step 3");

    //        Destroy(col2.gameObject);
            
    //    }
    //    else
    //    {
    //        Destroy(bullet);
    //    }

       
    
}
