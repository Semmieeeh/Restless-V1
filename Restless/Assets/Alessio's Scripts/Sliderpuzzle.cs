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
    //public bool sceneShift;
    //public float locknumbers;

    void Start()
    {
        percentageText = GetComponent<TMP_Text>();
        percentageTtdrie = GetComponent<TMP_Text>();
        percentageTexexttwee = GetComponent<TMP_Text>();
        percentageTextvier = GetComponent<TMP_Text>();
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
        percentageText.text = Mathf.RoundToInt(value * 10) + "%";
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
        percentageText.text = Mathf.RoundToInt(value * 10) + "%";
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
        percentageText.text = Mathf.RoundToInt(value * 10) + "%";
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
            
            SceneManager.LoadScene(1);
        }
    }

}
