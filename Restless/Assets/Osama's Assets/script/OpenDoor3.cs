using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor3 : MonoBehaviour
{
    public RaycastHit hit;
    public Vector3 v;
    public bool isOpen;
    public AudioSource source;
    public AudioClip a;


    void Update()
    {

        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "Garage")
            {
                if (Input.GetKeyDown("e"))
                {
                    if (isOpen == true)
                    {
                        v.x = 90;
                        isOpen = false;
                    }
                    else
                    {
                        v.x = -90;
                        isOpen = true;
                    }

                    hit.transform.Rotate(v);
                    source.PlayOneShot(a);
                }
            }
        }
    }
}
