using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solakh : MonoBehaviour {
    public Controlling playerscript;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    

    void OnCollisionEnter2D(Collision2D col2)
    {
        
        if (col2.gameObject.tag == "player")
        {
            playerscript.Damagetoplayer();
            
            GetComponent<BoxCollider2D>().enabled=false;

        }
    }
  
}
