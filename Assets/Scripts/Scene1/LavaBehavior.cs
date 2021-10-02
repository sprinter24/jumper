using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBehavior : MonoBehaviour
{
    public GameObject lava;
    public GameObject player;

    [SerializeField] private float lavaSpeedMultiply = 1f;
    [SerializeField] [Range(0f, 1f)] private float power = 1f;
    [SerializeField] private float lavaSpeedMultiplyDegree = 1f;
    [SerializeField] [Range(1f, 2f)] private float baseDegree = 1f;
    [SerializeField] private float maxDistance = 50f;

    public bool exponental = false;
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        if(lava.transform.position.y < player.transform.position.y)
        {
            float delta = -lava.transform.position.y + player.transform.position.y;
            if (!exponental)
            {
                lava.transform.position = new Vector3(lava.transform.position.x, lava.transform.position.y + Mathf.Pow(delta, power) * lavaSpeedMultiply, lava.transform.position.z);
            }
            else
            {
                lava.transform.position = new Vector3(lava.transform.position.x, lava.transform.position.y + Mathf.Pow(baseDegree, delta) * lavaSpeedMultiplyDegree, lava.transform.position.z);
            }
            if(delta > maxDistance)
            {
                lava.transform.position = new Vector3(lava.transform.position.x, player.transform.position.y - delta, lava.transform.position.z);
            }
        }
    }
}
