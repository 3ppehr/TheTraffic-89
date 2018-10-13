using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCodes : MonoBehaviour {
    public GameObject option;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Manager0.gamehasended = false;		
	}
    public void PlayGame()
    {
        option.SetActive(true);
        pausemenu.Gameispause = false;
        ScoringSystem.myScore = 0;
        Manager0.gamehasended = false;
        //Application.LoadLevel("Scence1");
    }
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
    public void donation()
    {
        Application.OpenURL("google.com");
    }
}
