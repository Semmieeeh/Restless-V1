using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrek : MonoBehaviour
{
    public AudioSource shrek;
    public bool shrekOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shrekOn == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                shrek.Play();
                shrekOn = true;

            }
        }
    }
}
