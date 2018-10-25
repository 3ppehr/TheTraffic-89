using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuLevel : MonoBehaviour {
    public GameObject panel;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("HighScore", 0) >= 1000)
        {
            panel.SetActive(false);
        }

    }
    public void Car1()
    {
        Application.LoadLevel("Scence1");
    }
    public void Car2()
    {
        Application.LoadLevel("Scence2");
    }
    public void Car3()
    {
        Application.LoadLevel("Scence3");
    }
}
