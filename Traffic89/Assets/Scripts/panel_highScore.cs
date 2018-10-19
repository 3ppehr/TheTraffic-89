using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_highScore : MonoBehaviour {
    public GameObject panel;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       if( PlayerPrefs.GetInt("HighScore", 0) >= 900)
        {
            panel.SetActive(false);
        }


    }
}
