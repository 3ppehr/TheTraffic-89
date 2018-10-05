using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scleteScripte : MonoBehaviour {
    public float speed1;
    Vector3 lastPos;
    public Controlling playerscript;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        //if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        //{
        //    transform.Translate(Vector2.up * Time.deltaTime * speed1 * (Mathf.Sqrt(transform.position.y / 100) + 1));
        //    Vector3 velocity = (this.transform.position - lastPos);

        //}

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


        if (col.gameObject.tag == ("crash car"))
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
