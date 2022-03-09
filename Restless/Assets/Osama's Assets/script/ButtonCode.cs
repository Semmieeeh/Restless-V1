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
    public GameObject gameOverMenu;
    public GameObject inventoryMenu;
    public Slider volumeSlider;

    public void Start()
    {

    }
    public void Update()
    {
        //if (gameOverMenu,gameInventory == true)
        // {
        //   canvasSound.Stop();
        // }
    }
    public void GeluidButton()
    {
        audioSource.Play();
    }
    public void CanvasGeluid()
    {
        canvasSound.Play();
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
    public void ChangeVolume(float newVolume)
    {
        AudioListener.volume = newVolume;
    }
}
