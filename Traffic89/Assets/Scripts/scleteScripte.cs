using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scleteScripte : MonoBehaviour {

    public Controlling playerscript;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("TheCar"))
        {
            playerscript.Damagetoplayer();
            Destroy(gameObject);
        }

        if (col.gameObject.tag == ("Bullet"))
        {

            Destroy(col.gameObject);
        }


        if (col.gameObject.tag == ("kale"))
        {

            Destroy(col.gameObject);
        }


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        
    }





    //public void Damagetoplayer()
    //{
    //    //bool tmp = EnemyInRange();

    //    playerscript.Health -= 1;
    //    Debug.Log(playerscript.Health);

    //}


}
