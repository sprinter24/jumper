using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInput : MonoBehaviour
{
    public static Vector2 direction; //ненормализованное

    public static float force;
    public static bool jump;

    public float planeZ = 0.5f;

    [Range(0f, 2000f)] public float maxForce;
    [Range(0f, 200f)] public float forceCorrection = 1f;

    public GameObject testBlock;
    public GameObject slider;

    [SerializeField] private float maxSliderScale = 0.5f;

    private bool fingerPressed = false;

    private Ray mouseRay;

    void Start()
    {
        
    }


    void Update()
    {
        JumpCheck();
        SliderBehavior(force, direction);
        testBlock.transform.position = TouchToWorld(); //точка для проверки положения касания
    }

    private void FixedUpdate()
    {
        FindForce();
        FindDirection();
    }

    private Vector3 TouchToWorld()
    {
        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        return Camera.main.transform.position + mouseRay.direction * (planeZ - Camera.main.transform.position.z) / mouseRay.direction.z;
    }

    private void FindForce()
    {
        force = direction.magnitude * forceCorrection;
        if (force > maxForce)
        {
            force = maxForce;
        }
    }

    private void FindDirection()
    {
        direction = Controller.player.transform.position - TouchToWorld();
    }


    public Vector2 ScreenMouseToWorld(Vector3 mousePos) //не используется
    {
        mousePos -= new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2, 0);
        mousePos.x /= Camera.main.pixelWidth;
        mousePos.y /= Camera.main.pixelHeight;
        return mousePos;
    }

    private void SliderBehavior(float f, Vector2 dir)
    {
        if (fingerPressed)
        {
            slider.SetActive(true);
            slider.transform.localScale = new Vector3(f / maxForce * maxSliderScale, f / maxForce * maxSliderScale, slider.transform.localScale.z);
            float angle = Mathf.Atan2(-dir.x, dir.y) * Mathf.Rad2Deg;
            slider.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        else
        {
            slider.SetActive(false);
        }

    }

    private void JumpCheck()
    {
        jump = false;

        if (Input.GetMouseButtonDown(0) && !fingerPressed)
        {
            fingerPressed = true;
        }
        if (fingerPressed && !Input.GetMouseButton(0))
        {
            fingerPressed = false;
            jump = true;
        }
    }

}
