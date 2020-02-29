using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Gioco"); //nome della scene
    }

    public void QuitGame()
    {
        Debug.Log("Gioco Chiuso");
        Application.Quit();
    }
}
