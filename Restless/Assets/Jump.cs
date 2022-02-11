using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int isJumping;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            isJumping+=1;
            if(isJumping<=2)
            {
                isGrounded=false;
                 GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity + Vector3.up * 5;
            }
        }
         
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isGrounded=true;
            if(isGrounded=true)
            {
                isJumping=0;
              
            }

        }

    }

}
