using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject sM;
    public GameObject fFM;
    public GameObject tOD;
    public GameObject sB;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "radio")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    sM.SetActive(false);
                    fFM.SetActive(false);
                    tOD.SetActive(false);
                    sB.SetActive(false);
                }
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "FF7")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    fFM.SetActive(true);
                }
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "TOD")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    tOD.SetActive(true);
                }
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "SB")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    sB.SetActive(true);
                }
            }
        }
    }
}