using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Sliderpuzzle : MonoBehaviour
{
    public TMP_Text percentageText;

    void Start()
    {
        percentageText = GetComponent<TMP_Text> ();
    }

    public void TextUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 100) + "%";
        if(value==1)
        {
            SceneManager.LoadScene(1);

        }
    }

}
