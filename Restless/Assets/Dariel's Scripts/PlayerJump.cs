using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public int isJumping;
    public bool isGrounded;


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJumping += 1;
            if (isJumping <= 1)
            {
                isGrounded = false;
                GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity + Vector3.up * 8;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
            if (isGrounded == true)
            {
                isJumping = 0;
            }
        }
    }
}
