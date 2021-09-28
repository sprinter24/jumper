using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickySpot : MonoBehaviour
{
    private Vector2 normalGravity = new Vector2(0, -1);
    private const float normalGravityScale = 20f;
    private const float platformGravityScale = 50f;

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
            Rigidbody player = other.GetComponent<Rigidbody>();
            player.angularVelocity = Vector3.zero;
            player.velocity = Vector3.zero;
            Physics.gravity = Vector3.zero;

            StartCoroutine(StopVelocity(player));

        }
        catch
        {
            Debug.LogError("Somethinh wrong with sticky platform");
        }

        /*
        if (transform.rotation.z == 90)
        {
            Physics.gravity = new Vector3(-1, 0, 0) * normalGravityScale;
        }
        else if (transform.rotation.z == 270)
        {
            Physics.gravity = new Vector3(1, 0, 0) * normalGravityScale;
        }
        else
        {
            Physics.gravity = new Vector2(Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.Deg2Rad), -Mathf.Cos(transform.rotation.eulerAngles.z * Mathf.Deg2Rad)) * platformGravityScale;
        }
        */

        
    }

    private void OnTriggerExit(Collider other)
    {
        Physics.gravity = normalGravity * normalGravityScale;
    }

    IEnumerator StopVelocity(Rigidbody player)
    {
        yield return new WaitForFixedUpdate();
        player.angularVelocity = Vector3.zero;
        player.velocity = Vector3.zero;
        yield return new WaitForFixedUpdate();
        player.angularVelocity = Vector3.zero;
        player.velocity = Vector3.zero;
    }
}
