using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionUI : MonoBehaviour
{
    public GameObject text;
    public RaycastHit hit;


    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "N9")
            {
                text.SetActive(true);
            }
            else
            {
                text.SetActive(false);
            }
        }

    }
}
