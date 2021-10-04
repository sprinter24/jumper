using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataConroller : MonoBehaviour
{
    public PointsManager pointManager;
    public void SaveScore()
    {
        int bestScore = PlayerPrefs.GetInt("bestScore");
        if(bestScore < pointManager.points)
        {
            bestScore = pointManager.points;
        }
        PlayerPrefs.SetInt("bestScore", bestScore);
        PlayerPrefs.Save();
    }
}
