using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text runScore;
    public Text highScore;
    void Start()
    {
        float currentScoref = PlayerPrefs.GetFloat("CurrentScore");

        runScore.text = currentScoref.ToString();
        
        if (currentScoref > PlayerPrefs.GetFloat("HighScore",0))
        {
            PlayerPrefs.SetFloat("HighScore", currentScoref);
            highScore.text = currentScoref.ToString();
        }

        // else
        // {
        //     highScore.text = PlayerPrefs.GetFloat("HighScore",0).ToString();
        // }
    }
}
