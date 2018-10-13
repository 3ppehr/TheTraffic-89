using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash_car : MonoBehaviour {
    

    public float speed1;
    Vector3 lastPos;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().gravityScale = -0.05f;
    }
	
	// Update is called once per frame
	void Update() {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed1 * (Mathf.Sqrt(transform.position.y / 100) + 1));
            //Vector3 velocity = (this.transform.position - lastPos);

        }
        //dotDestroy1.zoomOut();

       

        //speed = speed + Time.inFixedTimeStep;
        
         // dotDestroy1.zoomOut();
         //speed -= 0.009f;
         //GetComponent<Rigidbody2D>().gravityScale = GetComponent<Rigidbody2D>().gravityScale + speed;

        

         //GetComponent<Rigidbody2D>().gravityScale = GetComponent<Rigidbody2D>().gravityScale-speed;


    }

   
    void OnCollisionEnter2D(Collision2D col2)
    {
        if (col2.gameObject.tag == "Bullet")
        {
            Debug.Log("Bullet");
            Destroy(col2.gameObject);

        }
    }
    }
