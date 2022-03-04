using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TextMeshPro;

public class Puzzle : MonoBehaviour
{
    public TMPro.TMP_Text text;

    void Start()
    {
        text = GetComponent<TMPro.TMP_Text> ();
    }

    public void TextUpdate(float value)
    {
        text.text = Mathf.RoundToInt(value * 100) + "%";
    }
}

