using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text highscoretext;
    public Text scoreText;
    float score;
    

    void Start()
    {
        


        score = 0;

    }
    
    
    
        // Update is called once per frame
    void Update()
    {

        score += Time.deltaTime * 15; 
        scoreText.text = score.ToString("0"); //Display score on game screen whie playing
        PlayerPrefs.SetFloat("finalscore", score); //Saved score value for next scene

        if (score > PlayerPrefs.GetFloat("highscore"))
        {
            PlayerPrefs.SetFloat("highscore", score);
        }








    }
}

