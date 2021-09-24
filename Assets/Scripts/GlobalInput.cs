using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInput : MonoBehaviour
{
    public static Vector2 direction; //not normalized

    public static float force;
    public static bool jump;

    public float planeZ = 0.5f;

    [Range(0f, 2000f)] public float maxForce;
    [Range(0f, 200f)] public float forceCorrection = 1f;

    public GameObject testBlock;
    public GameObject slider;
    public GameObject firstTouchPointer;

    [SerializeField] private float maxSliderScale = 0.5f;

    private bool fingerPressed = false;

    private Ray mouseRay;

    [SerializeField] private bool jumpFromCube = true;
    private Vector2 firstPosition;

    void Start()
    {
        
    }


    void Update()
    {
        JumpCheck();
        SliderBehavior(force, direction);

        testBlock.transform.position = TouchToWorld(); //dot for test touch
    }

    private void FixedUpdate()
    {
        FindForce();
        if (jumpFromCube)
        {
            FindDirection();
        }
        FindDirectionFromPoint();
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

    private void FindDirectionFromPoint()
    {
        direction = firstPosition - (Vector2)TouchToWorld();
    }

    public Vector2 ScreenMouseToWorld(Vector3 mousePos) //doesn't use
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
            firstTouchPointer.SetActive(true);
            slider.SetActive(true); //pointer
            slider.transform.localScale = new Vector3(f / maxForce * maxSliderScale, f / maxForce * maxSliderScale, slider.transform.localScale.z);
            float angle = Mathf.Atan2(-dir.x, dir.y) * Mathf.Rad2Deg;
            slider.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        else
        {
            slider.SetActive(false);
            firstTouchPointer.SetActive(false); //pointer
        }

    }

    private void JumpCheck()
    {
        jump = false;

        if (Input.GetMouseButtonDown(0) && !fingerPressed)
        {
            fingerPressed = true;
            firstPosition = TouchToWorld();
            firstTouchPointer.transform.position = firstPosition; //pointer position
        }
        if (fingerPressed && !Input.GetMouseButton(0))
        {
            fingerPressed = false;
            jump = true;
        }
    }


}
