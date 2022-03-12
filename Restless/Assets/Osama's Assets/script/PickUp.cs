using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject n7;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3))
        {
            if (hit.transform.gameObject.tag == "N7")
            {
                if (Input.GetKeyDown("e"))
                {
                    n7.SetActive(true);
                    print("je hebt het opgepakt");
                }
            }
        }
    }
}
