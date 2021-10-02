using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem snow;

    [SerializeField] GameObject snowObject;
    [SerializeField] private Rigidbody player;

    private bool inTriiger = false;

    private Vector3 playerVelosity;

    [SerializeField] float maxSnowParticlesSpeed;
    [SerializeField] float minSnowParticlesSpeed;
    [SerializeField] float maxSnowParticlesRate;
    [SerializeField] float minSnowParticlesRate;
    [SerializeField] float maxForce;
    [SerializeField] float maxSnowParticlesSpeedOnPlatform;
    [SerializeField] float maxSnowParticlesRateOnPlatform;
    [SerializeField] float maxForceOnPlatform;


    [SerializeField] float duration;
    void Start()
    {
        snow.Stop();
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        playerVelosity = player.velocity;
        var main = snow.main;
        if (inTriiger)
        {
            snowObject.transform.position = new Vector3(player.transform.position.x, snowObject.transform.position.y, snowObject.transform.position.z);
            float force = player.velocity.magnitude;
            if(force >= maxForce) force = maxForceOnPlatform;
            main = snow.main;
            var emission = snow.emission;
            float speed = Mathf.Lerp(0, maxSnowParticlesSpeedOnPlatform, force / maxForceOnPlatform);
            float rate = Mathf.Lerp(0, maxSnowParticlesRateOnPlatform, force / maxForceOnPlatform);
            main.loop = true;
            main.startSpeed = speed;
            emission.rateOverTime = rate;
        }
        else
        {
            main.loop = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        try
        {
            inTriiger = true;
            float force;
            if(player.velocity.magnitude < playerVelosity.magnitude)
            {
                force = playerVelosity.magnitude;
            }
            else
            {
                force = player.velocity.magnitude;
            }
            if (force >= maxForce) force = maxForce;
            float speed = Mathf.Lerp(minSnowParticlesSpeed, maxSnowParticlesSpeed, force/maxForce);
            float rate = Mathf.Lerp(minSnowParticlesRate, maxSnowParticlesRate, force / maxForce);
            var main = snow.main;
            main.startSpeed = speed;
            var emission = snow.emission;
            emission.rateOverTime = rate;
            snowObject.transform.position = new Vector3(player.transform.position.x, snowObject.transform.position.y, snowObject.transform.position.z);
            snow.Play();
        }
        catch
        {
            Debug.LogWarning("snow particles get wrong Rigidbody");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        try
        {
            inTriiger = false;
        }
        catch
        {
            Debug.Log("not player exit from collider");
        }
    }
}
