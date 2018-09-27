using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed1 = -0.001f;
    private Transform target;
    public crash_car dotDestroy;


    public float speed;
    Vector3 lastPos;

    // Use this for initialization
    void Start()
    {
        //target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager0.gamehasended==false && pausemenu.Gameispause==false)
        {

            



            transform.Translate(Vector2.up * Time.deltaTime * speed * (Mathf.Sqrt(transform.position.y / 100) + 1));
            Vector3 velocity = (this.transform.position - lastPos);
        }

    }


    public void zoomOut()
    {
       

            Debug.Log("Bulletttttttttttttttttttttt");

       
        
    }
}
