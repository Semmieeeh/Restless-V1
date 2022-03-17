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
    public Vector3 v;
    public GameObject puzzel;
    public GameObject canvas;
    public GameObject startmenu;
    public RaycastHit hit;
    //public bool sceneShift;
    //public float locknumbers;

    void Start()
    {

    }

    public void TextUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 10) + "%";
        if(value>=0.37 && value < 0.43)
        {
            //SceneManager.LoadScene(1);
            vier=true;
        }
        else
        {
            vier=false;
        }
    }
    public void TextUpdatetwee(float value)
    {
        percentageTexttwee.text = Mathf.RoundToInt(value * 10) + "%";
        if(value>=0.67 && value < 0.73)
        {
            //SceneManager.LoadScene(1);
            zeven=true;
        }
        else
        {
            zeven=false;
        }
    }
    public void TextUpdatedrie(float value)
    {
        percentageTextdrie.text = Mathf.RoundToInt(value * 10) + "%";
        if(value>=0.27 && value < 0.33)
        {
            //SceneManager.LoadScene(1);
            drie=true;
        }
        else
        {
            drie=false;
        }
    }
    public void TextUpdatevier(float value)
    {
        percentageTextvier.text = Mathf.RoundToInt(value * 10) + "%";
        if(value>=0.87 && value < 0.93)
        {
            //SceneManager.LoadScene(1); 
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
            
            transform.Rotate(v);
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if (hit.transform.gameObject.tag == "Safedoor")
            {
                if (Input.GetKeyDown("e"))
                {
                    canvas.SetActive(true);
                    puzzel.SetActive(true);
                    startmenu.SetActive(false);
                    print("dit is de kluis");
                }
            }
        }
    }

}
