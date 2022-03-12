using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LC : MonoBehaviour
{
    public GameObject LockCursor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LockCursor.SetActive(true);
            print("werkt");
        }
    }
}
