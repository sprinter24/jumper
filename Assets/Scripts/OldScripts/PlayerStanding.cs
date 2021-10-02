using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStanding : MonoBehaviour
{
    public Rigidbody Player;
    public static bool Flag = true;

    private Vector3 LastRotation = Vector3.zero;
    private Vector3 NewRotation = Vector3.zero;


    void FixedUpdate()
    {
        LastRotation = NewRotation;
        NewRotation = Player.transform.rotation.eulerAngles;
        if (LastRotation - NewRotation == Vector3.zero && Player.velocity == Vector3.zero)
        {
            Flag = true;
        }
        else
        {
            Flag = false;
        }
    }
}