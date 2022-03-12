using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject sM;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3))
        {
            if (hit.transform.gameObject.tag == "radio")
            {
                if (Input.GetKeyDown("e"))
                {
                    sM.SetActive(false);
                }

            }
        }
    }
}