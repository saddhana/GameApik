using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class MainMenu : MonoBehaviour {

    public int currentLevel;
    private int next;
    public GameObject pausePanel;
    [SerializeField]
    private GameObject[] controller;

    //private Joystick joystick;

    private void Start()
    {
        controller = GameObject.FindGameObjectsWithTag("Control");
        //joystick = FindObjectOfType<Joystick>();
    }

    public void PlayGame()
    {
        SoundFX.playsound("select");
        SceneManager.LoadScene("Level 1");
    }

    public void GoToMenu()
    {
        //joystick.OnDisable();
        SoundFX.playsound("select");
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SoundFX.playsound("select");
        SceneManager.LoadScene("Level " + currentLevel);
    }

    public void Quit()
    {
        Time.timeScale = 1;
        SoundFX.playsound("select");
        Application.Quit();
    }

    public void NextLevel()
    {
        //joystick.OnDisable();
        SoundFX.playsound("select");
        next = currentLevel + 1;
        SceneManager.LoadScene("Level " + next);
    }

    public void PauseGame()
    {
        controller[0].SetActive(false);
        SoundFX.playsound("select");
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    }

    public void Resume()
    {
        controller[0].SetActive(true);
        SoundFX.playsound("select");
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        //Disable scripts that still work while timescale is set to 0
    }
}
