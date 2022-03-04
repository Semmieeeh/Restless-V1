using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public RaycastHit hit;
    public Vector3 v;
    public bool isOpentwo;
    public bool isClosedtwo;
    public AudioSource source;
    public AudioClip clip;


    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "Door")
            {
                if (Input.GetKeyDown("e"))
                {
                    if (isOpentwo == true)
                    {
                        v.z = 90;
                        isOpentwo = false;
                        isClosedtwo=true;
                    }
                    else
                    {
                        v.z = -90;
                        isOpentwo = true;
                        isClosedtwo=false;
                    }

                    hit.transform.Rotate(v);
                    source.PlayOneShot(clip);
                }
            }
        }
    }
}
