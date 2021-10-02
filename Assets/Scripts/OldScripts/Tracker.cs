using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    public GameObject Track;

    void OnEnable()
    {
        StartCoroutine("Sliding");
    }

    IEnumerator Sliding()
    {
        int i = -1;
        bool positive = true;
        while (PlayerStanding.Flag)
        {
            if (positive)
            {
                ++i;
                Track.transform.rotation = Quaternion.Euler(new Vector3(0, 0, i + PlayerController.PlayerAngle));
            }
            else
            {
                --i;
                Track.transform.rotation = Quaternion.Euler(new Vector3(0, 0, i + PlayerController.PlayerAngle));
            }
            if (i == 50) positive = false;
            if (i == -50) positive = true;
            yield return new WaitForFixedUpdate();
        }
    }
}
