using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject Key;
    public RaycastHit hit;
    public float range;

    private void Start()
    {
        range = 3;
    }


    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.transform.gameObject.tag == "Key")
            {
                
            }
        }
    }
}
