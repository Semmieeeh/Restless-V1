using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public RaycastHit hit;
    public Vector3 v;
<<<<<<< HEAD
    public bool isOpen;
=======
    public bool isOpentwo;
    public bool isClosedtwo;
    public bool isOpen;
    public bool isClosed;
>>>>>>> 51d85860a23bf87a0f27c3d8efca7cfb45bc5f80
    public AudioSource source;
    public AudioClip clip;

    public void Start()
    {
        isOpentwo = false;
        isClosedtwo = true;
        isClosed = true;
        isOpen = false;
    }
    void Update()
    {

        if (Physics.Raycast(transform.position, transform.forward, out hit, 3))
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
<<<<<<< HEAD
                        v.z = -90;
                        isOpen = true;
=======
                        v.z = 180;
                        isOpentwo = true;
                        isClosedtwo=false;
>>>>>>> 51d85860a23bf87a0f27c3d8efca7cfb45bc5f80
                    }

                    hit.transform.Rotate(v);
                    source.PlayOneShot(clip);
                }
            }
        }

        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "Door2")
            {
                if (Input.GetKeyDown("e"))
                {
                    if (isOpentwo == true)
                    {
                        v.z = 90;
                        isOpen = false;
                        isClosed = true;
                    }
                    else
                    {
                        v.z = 0;
                        isOpen = true;
                        isClosed = false;
                    }

                    hit.transform.Rotate(v);
                    source.PlayOneShot(clip);
                }
            }
        }
    }
}
