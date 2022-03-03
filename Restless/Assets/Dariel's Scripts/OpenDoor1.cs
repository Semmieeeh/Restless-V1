using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor1 : MonoBehaviour
{
    public RaycastHit hit;
    public Vector3 v;
    public bool isOpen;
    public bool isClosed;
    public AudioSource source;
    public AudioClip clip;

    public void Start(){
        isClosed = true;
    }

    void Update()
 {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 4))
        {
            if (hit.transform.gameObject.tag == "Door")
            {
                if (Input.GetKeyDown("e"))
                {
                    if (isOpen == true)
                    {
                        v.z = -90;
                        isOpen = false;
                        isClosed=true;
                    }
                    else
                    {
                        v.z = 90;
                        isOpen = true;
                        isClosed=false;
                    }

                    hit.transform.Rotate(v);
                    source.PlayOneShot(clip);
                }
            }
        }
    }
}
