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
    public Slider volumeSlider;
    public bool startMenuOn;

    public void Start()
    {

    }
    public void Update()
    {
        //if (gameOverMenu,gameInventory == true)
        // {
        //   canvasSound.Stop();
        // }
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryMenu.SetActive(true);
            startMenu.SetActive(false);
        }
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
        startMenu.SetActive(false);
        startMenuOn = false;
        if(startMenuOn == false)
        {
            print("ik ben uit");
            SceneManager.LoadScene(sceneName: "GameScene");
        }
        
    }
    public void ChangeVolume(float newVolume)
    {
        AudioListener.volume = newVolume;
    }
}
