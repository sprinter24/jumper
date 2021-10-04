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
        SetBestScore();
    }

    private void SetBestScore()
    {
        int bestScore;
        try
        {
            bestScore = PlayerPrefs.GetInt("bestScore");
            scoreText.text = "BEST SCORE: " + bestScore.ToString();
        }
        catch
        {
            PlayerPrefs.SetInt("bestScore", 0);
            Debug.LogWarning("There wasn't best score");
        }
    }
}
