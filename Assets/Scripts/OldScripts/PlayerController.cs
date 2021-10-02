using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject Track;
    public float force = 6000;
    public Slider ForceSlider;
    public static float PlayerAngle = 0f;

    private Rigidbody Player;

    void Start()
    {
        Player = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && PlayerStanding.Flag && (Input.mousePosition.x < 0.85 * Camera.main.pixelWidth || Input.mousePosition.y < Camera.main.pixelHeight * 0.87) && !PauseManager.Paused)
        {
            Player.AddForce(Track.transform.rotation * Vector3.up * force * ForceSlider.value);
        }
        if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            Vector2 pos = t.position;
            if(t.phase == TouchPhase.Began && PlayerStanding.Flag && (pos.x < 0.85 * Camera.main.pixelWidth || pos.y < Camera.main.pixelHeight * 0.87) && !PauseManager.Paused)
            {
                Player.AddForce(Track.transform.rotation * Vector3.up * force * ForceSlider.value);
            }
        }
    }

    void FixedUpdate()
    {

    }
}
