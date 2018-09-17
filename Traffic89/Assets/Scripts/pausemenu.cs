using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour {
    public GameObject PauswmenuUI;
    public static bool Gameispause = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    public void pause()
    {
        if (Gameispause)
        {
            Resume();
        }
        else
        {
            Paused();
        }
    }
    public void Resume()
    {
        PauswmenuUI.SetActive(false);
        Gameispause = false;
    }
    public void Paused()
    {
        PauswmenuUI.SetActive(true);
        Gameispause = true;

    }
    public void Rrestart()
    {
        Application.LoadLevel("Scence1");
        ScoringSystem.myScore = 0;
        Gameispause = false;
        
    }


    void Update () {
        
		
	}
}
