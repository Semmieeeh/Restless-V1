using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Sliderpuzzle : MonoBehaviour
{
    public TMP_Text percentageText;
    public TMP_Text percentageTexttwee;
    public TMP_Text percentageTextdrie;
    public TMP_Text percentageTextvier;
    public bool vier;
    public bool zeven;
    public bool drie;
    public bool negen;
    public bool codeGoed;
    public Vector3 v;
    public GameObject puzzel;
    public GameObject canvas;
    public GameObject startmenu;
    public GameObject themeMusic;
    public GameObject safedoor;
    public RaycastHit hit;
    public Transform door;

    public void TextUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 10).ToString();
        if(value>=0.35 && value < 0.45)
        {
            vier=true;
        }
        else
        {
            vier=false;
        }
    }
    public void TextUpdateTwee(float value)
    {
        percentageTexttwee.text = Mathf.RoundToInt(value * 10).ToString();
        if(value>=0.65 && value < 0.75)
        {
            zeven=true;
        }
        else
        {
            zeven=false;
        }
    }
    public void TextUpdateDrie(float value)
    {
        percentageTextdrie.text = Mathf.RoundToInt(value * 10).ToString();
        if(value>=0.25 && value < 0.35)
        {
            drie=true;
        }
        else
        {
            drie=false;
        }
    }
    public void TextUpdateVier(float value)
    {
        percentageTextvier.text = Mathf.RoundToInt(value * 10) +.ToString();
        if(value>=0.85 && value < 0.95)
        {
            negen=true;
        }
        else
        {
            negen=false;
        }
        
    }
    public void Update()
    {
        if(negen && drie && vier && zeven == true)
        {
           puzzel.SetActive(false);
           codeGoed=true;
            Cursor.lockState = CursorLockMode.Locked;
            if (codeGoed == true)
            {
                door.Rotate(new Vector3(0, 0, 90));  
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "Safedoor")
            {
                if (codeGoed == false)
                {
                    if (Input.GetKeyDown("e"))
                    {
                        puzzel.SetActive(true);
                        startmenu.SetActive(false);
                        themeMusic.SetActive(false);
                        Cursor.lockState = CursorLockMode.None;
                    }
                }
            }

            if(Input.GetKeyDown(KeyCode.Q))
                {
                    puzzel.SetActive(false);
                    Cursor.lockState = CursorLockMode.Locked;
                }
        }
    }

}
