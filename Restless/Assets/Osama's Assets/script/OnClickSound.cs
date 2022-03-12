using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickSound : MonoBehaviour
{
    public AudioSource audioSource;
    public void GeluidButton()
    {
        audioSource.Play();
    }
}
