using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor2 : MonoBehaviour
{
    public RaycastHit hit;
    public Vector3 v;
    public AudioSource shrek;
    public GameObject sM;
    public bool isOpen;
    public bool shrekOn;


    void Update()
    {

        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "ShrekDoor")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (shrekOn == false)
                    {
                        sM.SetActive(true);
                        shrekOn = true;
                        if (isOpen == true)
                        {
                            v.z = -90;
                            isOpen = false;
                        }
                        else
                        {
                            v.z = 90;
                            isOpen = true;
                        }
                    }

                    hit.transform.Rotate(v);
                }
            }
        }
    }
}
