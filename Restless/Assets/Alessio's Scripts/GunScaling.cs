using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScaling : MonoBehaviour
{
     public bool toggle;
     public Transform gun;


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (toggle == false)
            {
                
                toggle = true;
                transform.localScale += new Vector3(0f,1.40f,0f);
                transform.localPosition -= new Vector3(0f,0.30f,0f);
            }
 
            else if(toggle == true)
            {
                
                toggle = false;
                transform.localScale -= new Vector3(0f,1.40f,0f);
                transform.localPosition += new Vector3(0f,0.30f,0f);
            }
        }
    }
}
