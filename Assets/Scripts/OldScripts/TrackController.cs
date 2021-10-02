using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Track;


    void Start()
    {

    }


    void Update()
    {
        if (PlayerStanding.Flag)
        {
            Track.SetActive(true);
        }
        else
        {
            Track.SetActive(false);
        }
    }
}
