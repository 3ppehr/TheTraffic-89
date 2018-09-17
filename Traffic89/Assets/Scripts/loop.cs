using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour {
    public float speed;
    public float my_timer=0.0f;


    Vector3 _cameraLastPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        my_timer = my_timer + Time.deltaTime;
        Vector2 o = new Vector2(0,(_cameraLastPos - Camera.main.transform.position).y / 14);
        _cameraLastPos = Camera.main.transform.position;
        GetComponent<Renderer>().material.mainTextureOffset = GetComponent<Renderer>().material.mainTextureOffset - o;



    }
}
