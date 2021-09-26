using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float scoreRef;
    public void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        ScoreReference();
    }

    public float ScoreReference()
    {
        scoreRef = float.Parse(scoreText.text);

        PlayerPrefs.SetFloat("CurrentScore", scoreRef);

        return scoreRef;
    }
}
