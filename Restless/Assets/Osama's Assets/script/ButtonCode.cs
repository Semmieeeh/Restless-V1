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
            if (inventoryMenuOn == false)
            {
                inventoryMenu.SetActive(true);
                inventoryMenuOn = true;
                if (inventoryMenuOn == true)
                {
                    music.SetActive(false);
                }
            }   
        }
        if (inventoryMenuOn == true)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                inventoryMenu.SetActive(false);
                inventoryMenuOn = false;
            }
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
        startMenu.SetActive(false);
        startMenuOn = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (startMenuOn == false)
        {
            music.SetActive(false);
        }

    }
    public void ChangeVolume(float newVolume)
    {
        AudioListener.volume = newVolume;
    }
}
