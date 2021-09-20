using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInput : MonoBehaviour
{
    public static Vector2 direction;
    public static float force;
    public static bool jump;
    public float horizontalTouchCorrection;
    public float verticalTouchCorrection;

    [Range(0f, 2000f)] public float maxForce;
    [Range(0f, 200f)] public float forceCorrection = 1f;

    public GameObject testBlock;
    public GameObject slider;

    private bool fingerPressed = false;

    private Vector2 secondPosition;

    void Start()
    {
        
    }


    void Update()
    {
        jump = false;
        if (Input.GetMouseButtonDown(0) && !fingerPressed)
        {
            fingerPressed = true;
        }
        if(fingerPressed && Input.GetMouseButton(0))
        {
            secondPosition = new Vector2(ScreenMouseToWorld(Input.mousePosition).x * horizontalTouchCorrection, ScreenMouseToWorld(Input.mousePosition).y * verticalTouchCorrection * Mathf.Pow(Camera.main.pixelHeight / 1080f, 2) + Camera.main.transform.position.y);
        }
        if(fingerPressed && !Input.GetMouseButton(0))
        {
            direction = (Vector2) Controller.player.transform.position - secondPosition;
            force = direction.magnitude * forceCorrection;
            if(force > maxForce)
            {
                force = maxForce;
                Debug.Log("worked");
            }
            direction = direction.normalized;
            fingerPressed = false;
            jump = true;
        }
        testBlock.transform.position = new Vector3(ScreenMouseToWorld(Input.mousePosition).x * horizontalTouchCorrection, ScreenMouseToWorld(Input.mousePosition).y * verticalTouchCorrection * Mathf.Pow(Camera.main.pixelHeight / 1080f, 2) + Camera.main.transform.position.y, -2); // не ебу почему квадрат, надо бы узнать


    }

    public Vector2 ScreenMouseToWorld(Vector3 mousePos)
    {
        mousePos -= new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2, 0);
        mousePos.x /= Camera.main.pixelWidth;
        mousePos.y /= Camera.main.pixelHeight;
        return mousePos;
    }

}
