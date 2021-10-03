using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticSpike : MonoBehaviour
{
    Collider obj;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        try
        {
            Controller player = other.GetComponent<Controller>();
            player.Die();
        }
        catch
        {
            Debug.LogError("trigger touch other collider, move it somewhere");
        }
    }

}
