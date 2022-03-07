using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro:

public class Sliderpuzzle : MonoBehaviour
{
    TextMeshProUGUI percentageText;

    void start()
    {
        percentageText = GetComponent<TextMeshProUGUI> ();
    }

    public void textUpdate(float value)
    {
        percentageText.textUpdate = Mathf.RoundToInt(value * 100) + "%";
    }
}
