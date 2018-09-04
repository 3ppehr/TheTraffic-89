using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour {

    public float speed;
    public float myTimer = 0.0f;


    Vector3 _cameraLastPos;

    void LateUpdate()
    {


        myTimer = myTimer + Time.deltaTime;
        Vector2 offset = new Vector2(0, (_cameraLastPos - Camera.main.transform.position).y / 14);
        _cameraLastPos = Camera.main.transform.position;
        GetComponent<Renderer>().material.mainTextureOffset = GetComponent<Renderer>().material.mainTextureOffset - offset;
    }
}
