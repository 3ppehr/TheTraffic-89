﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager0 : MonoBehaviour {
    //public Controlling playerscript2;
    public Manager0 manage;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject gameover;
    public static bool gamehasended=false;
    public static bool Puase = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void EndGame()
    {
        if (gamehasended == false)
        {
            Button1.SetActive(false);
            Button2.SetActive(false);
            gameover.SetActive(true);
            gamehasended = true;
        }
    }



    
}
