using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour {
    public Manager0 Manager0;
    public GameObject PauswmenuUI;
    public static bool Gameispause = false;
    public GameObject left;
     public GameObject roght;

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
        roght.SetActive(true);
        left.SetActive(true);
        PauswmenuUI.SetActive(false);
        Gameispause = false;
    }
    public void Paused()
    {
        roght.SetActive(false);
        left.SetActive(false);
        PauswmenuUI.SetActive(true);
        Gameispause = true;

    }
    public void Rrestart()
    {
        Manager0.gamehasended = false;
        Application.LoadLevel("Scence1");
        ScoringSystem.myScore = 0;
        Gameispause = false;
        
    }


    void Update () {
        
		
	}
}
