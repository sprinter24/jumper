using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    [SerializeField] private Text pointsBar;

    [SerializeField] private Transform player;

    [SerializeField] private float coordinatesForPoint = 1f;
    private float lastPosition;

    public int points = 0;
    

    void Start()
    {
        lastPosition = player.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player.position.y >= lastPosition + coordinatesForPoint)
        {
            ++points;
            lastPosition = player.position.y;
            pointsBar.text = points.ToString();
        }
    }
}
