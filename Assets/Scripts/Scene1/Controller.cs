using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public static Rigidbody player;
    public DataConroller dataController;
    public GameObject DieMenu;

    [SerializeField] bool VelocityStand = true;
    private bool canJump = true;
    private bool shiftPressed = false; // delete on release

    [SerializeField] float timeToNextJump = 2f;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) // delete on release
        {
            shiftPressed = true;
        }

        if (GlobalInput.jump)
        {
            if (VelocityStand)
            {
                if(player.velocity == Vector3.zero && player.angularVelocity == Vector3.zero || shiftPressed)
                {
                    player.AddForce(GlobalInput.direction.normalized * GlobalInput.force);
                }
            }
            else
            {
                if (canJump || shiftPressed)
                {
                    player.AddForce(GlobalInput.direction.normalized * GlobalInput.force);
                    StartCoroutine(JumpDelay());
                    canJump = false;
                }
            }
        }

    }

    private void FixedUpdate()
    {
        
    }

    IEnumerator JumpDelay()
    {
        yield return new WaitForSeconds(timeToNextJump);
        canJump = true;
    }

    public void Die()
    {
        MenuManger.died = true;
        dataController.SaveScore();
        player.gameObject.SetActive(false);
        DieMenu.SetActive(true);
        Debug.Log("Tak i pomer ded maksim, da i hui ostalcya s nim");
    }

}
