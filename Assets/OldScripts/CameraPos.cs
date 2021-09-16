using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public GameObject Player;


    void Update()
    {
        transform.position = new Vector3(transform.position.x, Player.transform.position.y + 1, transform.position.z);
    }
}
