using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public Text highScoreText;
    float newHighScore;

   
    // Update is called once per frame
    void Update()
    {
        newHighScore = PlayerPrefs.GetFloat("highscore");
        highScoreText.text = newHighScore.ToString("0"); 


    }
}

