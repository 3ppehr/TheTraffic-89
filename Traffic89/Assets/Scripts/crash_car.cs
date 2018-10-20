using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash_car : MonoBehaviour {
    

    public float speed1;
    Vector3 lastPos;

    // Use this for initialization
    void Start () {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {
            //GetComponent<Rigidbody2D>().gravityScale = -0.05f;
        }
    }
	
	// Update is called once per frame
	void Update() {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed1 * (Mathf.Sqrt(transform.position.y / 100) + 1));
            //Vector3 velocity = (this.transform.position - lastPos);

        }
        else
        {
            transform.Translate(Vector2.up * Time.deltaTime * 0f * (Mathf.Sqrt(transform.position.y / 100) + 1));
            GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
            

        

    }

   
    void OnCollisionEnter2D(Collision2D col2)
    {
        //if (col2.gameObject.tag == "Bullet")
        //{
        //    Debug.Log("Bullet");
        //    Destroy(col2.gameObject);

        //}




        if (col2.gameObject.tag == "crash car")
        {
            Debug.Log("crash car");
            Destroy(col2.gameObject);

        }
    }



   



}
