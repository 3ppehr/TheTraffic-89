using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnCollisionEnter2D(Collision2D col2)
    {
        Debug.Log("Collision");
            Destroy(col2.gameObject);
            Destroy(gameObject);
       
    }
}
