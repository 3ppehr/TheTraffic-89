using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {
    public float myTimer;
    public Text Score;
    public float myScore=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        myTimer = Time.deltaTime + myTimer;
        if(myTimer>=1)
        {
            myTimer = 0;
            myScore += 10;
            Score.text = myScore.ToString();
        }

	}
}
