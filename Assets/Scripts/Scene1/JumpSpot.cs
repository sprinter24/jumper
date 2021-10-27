using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSpot : MonoBehaviour
{
    private float angleA;
    public float expectionForce = 100f;

    [SerializeField] private float jumpMultiply = 2f;
    
    void Start()
    {
        angleA = 90 + transform.rotation.eulerAngles.z;
    }

    
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        try
        {
            Rigidbody player = other.GetComponent<Rigidbody>();
            Vector2 direction = player.velocity;
            if(direction.magnitude >= 10)
            {
                float force = direction.magnitude;
                float angleB = 90 - Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
                player.velocity = new Vector3(Mathf.Cos((180 + 2 * angleA - angleB) * Mathf.Deg2Rad), Mathf.Sin((180 + 2 * angleA - angleB) * Mathf.Deg2Rad), 0) * force * jumpMultiply;
            }
            else
            {
                player.velocity = new Vector3(Mathf.Cos(angleA * Mathf.Deg2Rad), Mathf.Sin(angleA * Mathf.Deg2Rad), 0) * expectionForce;
                Debug.Log(player.velocity);
            }
        }
        catch
        {
            Debug.LogWarning("something wrong with jump spot");
        }

    }
}
