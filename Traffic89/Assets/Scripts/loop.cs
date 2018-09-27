using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour {
    public float speed;
    public float my_timer=0.0f;
    public float myTimer = 0.0f;

    Vector3 _cameraLastPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //if we're not puased
       
            //we give my timer the delta time value
            myTimer = myTimer + Time.deltaTime;
            //if mytimer hit 10 seconds:

            //if we're not puased and we still have hp
            
                Vector2 offset = new Vector2(0, (_cameraLastPos - Camera.main.transform.position).y / 14);
                _cameraLastPos = Camera.main.transform.position;
                GetComponent<Renderer>().material.mainTextureOffset = GetComponent<Renderer>().material.mainTextureOffset - offset;
           
        
    }
}
