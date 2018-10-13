using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlocked : MonoBehaviour {
    public static int level1=1;
    public int max_level;
    public GameObject[] levelunlocked;
    // Use this for initialization
    void Start () {
        level1 = PlayerPrefs.GetInt("level1", level1);

    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 1; i < max_level; i++)
        {
            if (i <= level1)
            {
                levelunlocked[i].SetActive(false);    
                           
            }
            else
            {
                levelunlocked[i].SetActive(true);

            }
        }
       
	}
    public static void NextLevel()
    {
        level1 += 1;
        PlayerPrefs.SetInt("level1", level1);
    }
    public void Reset()
    {
        level1 = 1;
        PlayerPrefs.SetInt("level1", level1);
    }
    public void add_level()
    {
        NextLevel();
        Application.LoadLevel("Main");
    }
}
