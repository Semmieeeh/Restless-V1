using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public RaycastHit hit;
    public Vector3 v;
    public bool isOpen;
    public AudioSource source;
    public AudioClip clip;


    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
        {
            if (hit.transform.gameObject.tag == "Door")
            {
                if (Input.GetKeyDown("e"))
                {
                    if (isOpen == true)
                    {
                        v.z = 90;
                        isOpen = false;
                    }
                    else
                    {
                        v.z = -90;
                        isOpen = true;
                    }

                    hit.transform.Rotate(v);
                    source.PlayOneShot(clip);
                }
            }
        }
    }
}
