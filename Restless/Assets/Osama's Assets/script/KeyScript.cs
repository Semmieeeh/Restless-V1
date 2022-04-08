using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject key;
    public GameObject keyCanva;
    public GameObject gameEnd;

    void Start()
    {

    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "Key")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    keyCanva.SetActive(true);
                    key.SetActive(false);
                    sleutelOpgepakt = true;
                }
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (sleutelOpgepakt == true)
            {
                if (hit.transform.gameObject.tag == "Auto")
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        gameEnd.SetActive(true);
                        Cursor.lockState = CursorLockMode.None;
                    }
                }
            }
        }
    }
}