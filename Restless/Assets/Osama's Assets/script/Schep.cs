using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schep : MonoBehaviour
{
    public bool schepOpgepakt;
    public RaycastHit hit;
    public GameObject schep;
    public GameObject schepI;
    public GameObject graf1;


    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "Schep")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    schep.SetActive(false);
                    schepI.SetActive(true);
                    schepOpgepakt = true;
                }
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "graf")
            {
                if (schepOpgepakt == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        graf1.SetActive(false);
                    }
                }
            }
        }
    }
}
