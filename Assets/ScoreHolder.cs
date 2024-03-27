using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public Text newScoreText;
    float newScore;
   

    // Update is called once per frame
    void Update()
    {
        newScore = PlayerPrefs.GetFloat("finalscore");
        newScoreText.text = newScore.ToString("0");

       

    }
}
