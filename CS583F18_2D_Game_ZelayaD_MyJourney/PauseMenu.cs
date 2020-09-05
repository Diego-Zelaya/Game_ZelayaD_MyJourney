//maybe work not sure
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GamePaused = false;
    public GameObject pauseMenuUI;
    //public LoadScene menuGame;


    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) { 
            if (GamePaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }//end of void update


    //resumes game while in the pause menu
    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    //pauses game when pressing escape key
    void Pause () {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    //loads game when pressing the menu button in pauseMenu
    public void LoadMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    //quits game when pressing the quit button in pauseMenu
    public void QuitGame(){
        Application.Quit();
    }

}//end of class PauseMenu
