using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public Vector3 v;
    public float speed;
    public bool crouchspeed;
    public bool sprintspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal=Input.GetAxis("Horizontal");
        v.x=horizontal;
        vertical=Input.GetAxis("Vertical");
        v.z=vertical;
        if(Input.GetButtonDown("Crouch"))
        {
            if(crouchspeed==false)
            {
                crouchspeed=true;
                speed=0.5f;

            }
            else if(crouchspeed==true)
            {
                crouchspeed=false;
                speed=5f;

            }


        }
        if(Input.GetButtonDown("left ctrl"))
        {
            if(sprintspeed==false)
            {
                sprintspeed=true;
                speed=8.5f;

            }
            else if(sprintspeed==true)
            {
                sprintspeed=false;
                speed=5f;

            }


        }
        
        
        

        transform.Translate(v*speed*Time.deltaTime);
    }
}
