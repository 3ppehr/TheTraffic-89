using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeScript : MonoBehaviour {
    public Controlling playerscript;
    public GameObject life;
    int tmp;

    // Use this for initialization
    void Start () {
         tmp = playerscript.Health;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void manageLifeScript()
    {
        

    }
    void OnCollisionEnter2D(Collision2D col2)
    {
        //if (col2.gameObject.tag == "Bullet")
        //{
        //    Debug.Log("Bullet");
        //    Destroy(col2.gameObject);

        //}

        


        if (col2.gameObject.name.Equals("TheCar"))
        {

            Debug.Log("crash car tmp");
            playerscript.lifePlayer();
            tmp++;
            Destroy(life);

        }
    }
}
