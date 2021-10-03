using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataConroller : MonoBehaviour
{
    public PointsManager pointManager;
    public void SaveScore()
    {
        PlayerPrefs.SetInt("Score", pointManager.points);
        PlayerPrefs.Save();
    }
}
