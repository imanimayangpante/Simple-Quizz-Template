using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject interactiveUI;
    public GameObject playerData;
    public GameObject pauseBTN;
    public GameObject pauseMenu;
    public GameObject helpMenu;

    public void OpenPauseMenu() 
    {
        interactiveUI.SetActive(false);
        playerData.SetActive(false);
        pauseBTN.SetActive(false);
        pauseMenu.SetActive(true);
        helpMenu.SetActive(false);
    }

    public void ResumeGame() 
    {
        interactiveUI.SetActive(true);
        playerData.SetActive(true);
        pauseBTN.SetActive(true);
        pauseMenu.SetActive(false);
        helpMenu.SetActive(false);
    }

    public void OpenHelp() 
    {
        interactiveUI.SetActive(false);
        playerData.SetActive(false);
        pauseBTN.SetActive(false);
        pauseMenu.SetActive(false);
        helpMenu.SetActive(true);
    }
}
