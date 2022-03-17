using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject n7;
    public GameObject n4;
    public GameObject n3;
    public GameObject n9;
    public GameObject canva;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3))
        {
            if (hit.transform.gameObject.tag == "N7")
            {
                canva.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    n7.SetActive(true);
                    print("je hebt n7 het opgepakt");
                }
            }
            if (hit.transform.gameObject.tag == "N4")
            {
                canva.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    n4.SetActive(true);
                    print("je hebt n4 het opgepakt");
                }
            }
            if (hit.transform.gameObject.tag == "N3")
            {
                canva.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    n3.SetActive(true);
                    print("je hebt n3 het opgepakt");
                }
            }
            if (hit.transform.gameObject.tag == "N9")
            {
                canva.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    n9.SetActive(true);
                    print("je hebt n9 het opgepakt");
                }
            }
        }
    }
}
