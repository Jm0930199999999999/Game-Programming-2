using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public float score;

    public float highScore;

    public Text highScoreText;

    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;

        highScore = PlayerPrefs.GetFloat("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        highScoreText.text = "HighScore: " + highScore.ToString();
    }

    public void AddScore()
    {
        score++;
        if (score > highScore)
        {
            //change our highscore number
            highScore = score;
            PlayerPrefs.SetFloat("HighScore", highScore);
        }
    }
}
