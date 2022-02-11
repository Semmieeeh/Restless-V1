using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 movement;
    public float horizontal;
    public float vertical;
    public float walkSpeed;
    public float sprintSpeed;
    public float crouchSpeed;
    public bool isSprinting;
    public bool isWalking;
    public bool isCrouching;

    void Start()
    {
        crouchSpeed = 3f;
        walkSpeed = 5f;
        sprintSpeed = 8f;
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        movement.x = horizontal;
        vertical = Input.GetAxis("Vertical");
        movement.z = vertical;
        transform.Translate(movement * walkSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
            isWalking = false;
            walkSpeed = sprintSpeed;
        }
        else
        {
            isSprinting = false;
            isWalking = true;
            walkSpeed = 5f;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = true;
            walkSpeed = crouchSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = false;
            walkSpeed = 5f;
        }
    }
}
