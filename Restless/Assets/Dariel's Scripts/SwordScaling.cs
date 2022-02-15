using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScaling : MonoBehaviour
{
    public bool toggle;
    public Transform sword;


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (toggle == false)
            {
                toggle = true;
                transform.localScale += new Vector3(0f, 0.2f, 0f);
                transform.localPosition -= new Vector3(0f, 0.30f, 0f);
            }

            else if (toggle == true)
            {
                toggle = false;
                transform.localScale -= new Vector3(0f, 0.14f, 0f);
                transform.localPosition += new Vector3(0f, 0.30f, 0f);
            }
        }
    }
}
