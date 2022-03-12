using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject sM;
    public GameObject fFM;
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
                if (Input.GetKeyDown("e"))
                {
                    sM.SetActive(false);
                    fFM.SetActive(false);
                }

            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "FF7")
            {
                if (Input.GetKeyDown("e"))
                {
                    fFM.SetActive(true);
                }

            }
        }
    }
}