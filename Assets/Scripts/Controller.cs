using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public static Rigidbody player;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalInput.jump)
        {
            player.AddForce(GlobalInput.direction.normalized * GlobalInput.force);
            Debug.Log(GlobalInput.force);
        }
    }
}
