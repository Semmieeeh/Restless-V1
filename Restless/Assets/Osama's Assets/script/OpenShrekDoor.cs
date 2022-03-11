using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShrekDoor : MonoBehaviour
{
    public RaycastHit hit;
    public Vector3 v;
    public bool shrekOn;
    public bool isOpen;
    public AudioSource shrek;
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3))
        {
            if (hit.transform.gameObject.tag == "ShrekDoor")
            {
                if (Input.GetKeyDown("e"))
                {
                    if (shrekOn == false)
                    {
                        shrek.Play();
                        shrekOn = true;
                        if (isOpen == false)
                        {
                            v.z = 90;
                            isOpen = true;
                            if (isOpen == true)
                            {
                                v.z = -90;
                                isOpen = false;
                            }
                        }
                    }
                    hit.transform.Rotate(v);
                }
            }
            
        }
    }
}
