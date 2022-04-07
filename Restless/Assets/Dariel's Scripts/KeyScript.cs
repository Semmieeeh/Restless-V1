using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public float range;
    public RaycastHit hit;
    public GameObject key;
    public GameObject keyCanva;
    public GameObject gameEnd;
    public bool sleutelOpgepakt;

    void Start()
    {
        range = 3;
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.transform.gameObject.tag == "Key")
            {
                if (Input.GetKeyDown("e"))
                {
                    keyCanva.SetActive(true);
                    key.SetActive(false);
                    sleutelOpgepakt = true;
                }
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (sleutelOpgepakt == true)
            {
                if (hit.transform.gameObject.tag == "Auto")
                {
                    if (Input.GetKeyDown("e"))
                    {
                        gameEnd.SetActive(true);
                        Cursor.lockState = CursorLockMode.None;
                    }
                }
            }
        }
    }
}
