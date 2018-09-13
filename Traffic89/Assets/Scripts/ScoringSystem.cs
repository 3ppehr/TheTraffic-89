using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {
    public float myTimer;
    public GameObject jigar;
    // public ScoringSystem Scoring;

    public Text Score;
    public float myScore=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Manager0.gamehasended == false)
        {
            myTimer = Time.deltaTime + myTimer;
            if (myTimer >= 1)
            {

                myTimer = 0;
                myScore += 0;
                Score.text = myScore.ToString();


                if (myScore == 100)
                {
                    jigar.SetActive(true);
                }

            }
        }

	}



    public void _score()


    {
        myScore += 100;

    }

    public void _jigarscore()


    {
       
    }
}
