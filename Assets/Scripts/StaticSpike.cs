using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticSpike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
