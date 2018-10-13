using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {
    public float myTimer;
    public GameObject jigar;
    public Text HighScore = null;
    // public ScoringSystem Scoring;

    public Text Score;
    public Text Score1;
    public static int myScore=0;
	// Use this for initialization
	void Start () {
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

	}
	
	// Update is called once per frame
	void Update () {
        if(myScore>PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", myScore);
            HighScore.text = myScore.ToString();
        }
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {
            myTimer = Time.deltaTime + myTimer;
            if (myTimer >= 1)
            {

                myTimer = 0;
                myScore += 0;
                Score.text = myScore.ToString();
                Score1.text = myScore.ToString();

                if (myScore == 1000)
                {
                    jigar.SetActive(true);
                }
                if (myScore == 2000)
                {
                    jigar.SetActive(false);
                }

            }
        }

	}



    public void _score()


    {
        myScore += 100;

    }


    public void _score_()


    {
        myScore += 100;

    }


}
