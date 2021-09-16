using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public float LastPosition;
    public int Score = 0;
    public GameObject Player;
    public Text Bar;

    void Start()
    {
        LastPosition = Player.transform.position.y;
    }

    void Update()
    {
        Bar.text = Score.ToString();
        if(LastPosition + 1 <= Player.transform.position.y)
        {
            LastPosition += 1;
            ++Score;
        }
    }

}
