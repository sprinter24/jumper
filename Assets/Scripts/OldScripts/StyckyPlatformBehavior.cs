using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StyckyPlatformBehavior : MonoBehaviour
{
    public GameObject Player;
    public GameObject Platform;
    public Transform DirectionDot;
    public Vector3 Direction;
    public Rigidbody PlayerRb;
    public float Strength = 100f;

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision that)
    {
        PlayerRb.velocity = Vector3.zero;
        StartCoroutine("GravForce");
        that.rigidbody.useGravity = false;
        PlayerController.PlayerAngle = Platform.transform.rotation.eulerAngles.z;
    }

    void OnCollisionExit(Collision that)
    {
        StopCoroutine("GravForce");
        that.rigidbody.useGravity = true;
        PlayerController.PlayerAngle = 0;
    }

    IEnumerator GravForce()
    {
        while(true)
        {
            PlayerRb.AddForce((- Player.transform.position + Platform.transform.position) * Strength);
            yield return new WaitForFixedUpdate();
        }
    }
}
