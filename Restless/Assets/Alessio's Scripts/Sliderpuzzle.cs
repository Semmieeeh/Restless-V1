using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderpuzzle : MonoBehaviour
{
    Text percentageText;

    void start()
    {
        percentageText = GetComponent<Text> ();
    }

    public void textUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 100) + "%";
    }
}
