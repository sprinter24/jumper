using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetBestScore : MonoBehaviour
{
    private int score;
    public Text scoreText;
    void Start()
    {
        GetLastScore();
        SetBestScore();
    }

    private void GetLastScore()
    {
        try
        {
            score = PlayerPrefs.GetInt("Score");
        }
        catch
        {
            Debug.LogWarning("There wasn't score");
            score = 0;
        }
    }

    private void SetBestScore()
    {
        int bestScore;
        try
        {
            bestScore = PlayerPrefs.GetInt("bestScore");
            if(bestScore < score)
            {
                PlayerPrefs.SetInt("bestScore", score);
                bestScore = score;
            }
            scoreText.text = "BEST SCORE: " + score.ToString();
        }
        catch
        {
            PlayerPrefs.SetInt("bestScore", 0);
            Debug.LogWarning("There wasn't best score");
        }
    }
}
