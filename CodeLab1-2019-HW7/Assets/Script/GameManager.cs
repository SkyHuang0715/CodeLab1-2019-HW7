using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //int score;
    public Text scoreText;
    

    

    int score = 0;

    public int Score
    {

        get
        {
            return score;
        }
        
        set
        {
            score = value;
            scoreText.text = "Score " + score;

        }
    }



    public static GameManager instance;
    
    
    // Start is called before the first frame update
    void Start()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            

        }
        else
        {
            Destroy(gameObject);
        }

        Score = 0;


        // print(File.ReadAllText(Application.dataPath + FILE_HIGH_SCORE));


    }
}
