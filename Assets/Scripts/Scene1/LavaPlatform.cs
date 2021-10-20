using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaPlatform : MonoBehaviour
{
    [SerializeField] private float minForce;
    [SerializeField] private float maxForce;

    [Range(0f, 90f)] public float minAngle;
    [Range(0f, 90f)] public float maxFirstAngle;
    [Range(90f, 180f)] public float minSecondAngle;
    [Range(90f, 180f)] public float maxAngle;
    [SerializeField] private float timeBeforeKick = 2f;

    private bool inTrigger = false;

    private Rigidbody player;


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        try
        {
            player = other.GetComponent<Rigidbody>();
            inTrigger = true;
            float angle;
            if (Random.Range(0, 2) == 0)
            {
                angle = Random.Range(minAngle, maxFirstAngle);
            }
            else
            {
                angle = Random.Range(minSecondAngle, maxAngle);
            }
            float force = Random.Range(minForce, maxForce);
            StartCoroutine(AddForce(force, angle));
        }
        catch
        {
            Debug.LogError("Lava platform, tocuh not player, on postion " + transform.position);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    IEnumerator AddForce(float force, float angle)
    {
        for(float i = 0; i <= timeBeforeKick; i += Time.fixedDeltaTime)
        {
            
            if (!inTrigger)
            {
                yield break;
            }
            yield return new WaitForFixedUpdate();
        }
        player.AddForce(force * new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad), 0));
    }
}
