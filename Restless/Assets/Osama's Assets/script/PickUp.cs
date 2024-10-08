using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //canvas
    public RaycastHit hit;
    public GameObject n7;
    public GameObject n4;
    public GameObject n3;
    public GameObject n9;

    //objects
    public GameObject papier7;
    public GameObject papier4;
    public GameObject papier3;
    public GameObject papier9;
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "N7")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    n7.SetActive(true);
                    papier7.SetActive(false);
                }
            }
            if (hit.transform.gameObject.tag == "N4")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    n4.SetActive(true);
                    papier4.SetActive(false);
                }
            }
            if (hit.transform.gameObject.tag == "N3")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    n3.SetActive(true);
                    papier3.SetActive(false);
                }
            }
            if (hit.transform.gameObject.tag == "N9")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    n9.SetActive(true);
                    papier9.SetActive(false);
                }
            }
        }
    }
}
