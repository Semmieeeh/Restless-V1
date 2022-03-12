using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCode : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject startMenu;
    public GameObject gameOverMenu;
    public GameObject inventoryMenu;
    public GameObject canvas;
    public GameObject lockCursor;
    public GameObject music;
    public Slider volumeSlider;
    public bool startMenuOn;
    public bool inventoryMenuOn;

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
                inventoryMenuOn = true;
                if (inventoryMenuOn == true)
                {
                    music.SetActive(false);
                }
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
        if (startMenuOn == false)
        {
            //lockCursor.SetActive(true);
        }
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
