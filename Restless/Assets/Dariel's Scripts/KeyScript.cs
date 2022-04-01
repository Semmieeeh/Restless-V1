using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public float range;
    public RaycastHit hit;
    public GameObject key;
    public GameObject keyCanva;

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
                keyCanva.SetActive(true);
                key.SetActive(false);
            }
        }
    }
}
