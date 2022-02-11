using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCode : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource canvasSound;
    public GameObject optionsMenu;
    public GameObject startMenu;
    public Slider volumeSlider;
    public void Muziek()
    {
        audioSource.Play();
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Options()
    {
        optionsMenu.SetActive(true);
        startMenu.SetActive(false);
    }
    public void StartMenu()
    {
        optionsMenu.SetActive(false);
        startMenu.SetActive(true);
    }
}
