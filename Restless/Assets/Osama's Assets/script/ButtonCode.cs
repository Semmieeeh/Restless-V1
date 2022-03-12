using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCode : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource canvasSound;
    public GameObject optionsMenu;
    public GameObject startMenu;
    public GameObject gameOverMenu;
    public GameObject inventoryMenu;
    public GameObject canvas; 
    public Slider volumeSlider;
    public bool startMenuOn;

    public void Start()
    {

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (startMenuOn == false)
            {
                canvas.SetActive(true);
                startMenu.SetActive(false);
                inventoryMenu.SetActive(true);
                startMenuOn = true;
            }   
        }
        if (startMenuOn == true)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                canvas.SetActive(false);
                startMenuOn = false;
            }
        }
        //if (startMenuOn == false)
        //{
        //    GetComponent<LockCursor>.().enabled = true;
        //}
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
    public void StartGame()
    {
        canvas.SetActive(false);
        startMenuOn = false;
        
    }
    public void ChangeVolume(float newVolume)
    {
        AudioListener.volume = newVolume;
    }
}
