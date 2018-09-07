﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp_1 : MonoBehaviour {
    private SpriteRenderer spriteRenderer;
    public Controlling playerscript;
    [SerializeField]
    Sprite FullHP;
    [SerializeField]
    Sprite LowHP;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {

        ManageHeart();
    }
    void ManageHeart()
    {
        int tmp = playerscript.Health;
        if (tmp == 3)
        {
            spriteRenderer.sprite = LowHP;
        }
    }
}