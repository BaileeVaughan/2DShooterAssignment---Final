//------------------------------------------------------------------------------
// Author: Bailee Vaughan
// Title: MainMenu
// Date: 29th May
// Details: Start and quit features
// URL: 
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("GameExit");
        Application.Quit();
    }
}
