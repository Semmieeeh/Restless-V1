using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schep : MonoBehaviour
{
    public bool schepOpgepakt;
    public RaycastHit hit;
    public GameObject schep;
    public GameObject schepI;
    public GameObject graf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "Schep")
            {
                if (Input.GetKeyDown("e"))
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
                    if (Input.GetKeyDown("e"))
                    {
                        graf.SetActive(false);
                        print("hallo?");
                    }
                }
            }
        }
    }
}
