using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IlluminationControl : MonoBehaviour
{
    [SerializeField] private Light globalLight;
    [SerializeField] private Light lightNearPlayer;
    [SerializeField] private Light lightOnPlayer;
    [SerializeField] private float globalLightIntensity;
    [SerializeField] private float lightNearPlayerIntensity;
    [SerializeField] private float lightOnPlayerIntensity;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            TurnOnLight();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            TurnOffLight();
        }
    }

    public void TurnOffLight()
    {
        globalLight.intensity = 0;
        lightNearPlayer.intensity = lightNearPlayerIntensity;
        lightOnPlayer.intensity = lightOnPlayerIntensity;
    }

    public void TurnOnLight()
    {
        globalLight.intensity = globalLightIntensity;
        lightNearPlayer.intensity = 0;
        lightOnPlayer.intensity = 0;
    }
}
