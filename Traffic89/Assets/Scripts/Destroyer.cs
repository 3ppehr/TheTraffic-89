﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject re;
    public GameObject shoot;
    public GameObject GameOverUI;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
            Destroy(col.gameObject);
        if (col.gameObject.tag == "player")
        {
            shoot.SetActive(false);
            re.SetActive(true);
            GameOverUI.SetActive(true);
            Manager0.gamehasended = true;
        }
        
     
    }
}

