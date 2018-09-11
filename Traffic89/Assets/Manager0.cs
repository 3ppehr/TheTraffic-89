using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager0 : MonoBehaviour {
    //public Controlling playerscript2;
    public Manager0 manage;
    public GameObject gameover;
    public static bool gamehasended=false;
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
            gameover.SetActive(true);
            gamehasended = true;
        }
    }
}
