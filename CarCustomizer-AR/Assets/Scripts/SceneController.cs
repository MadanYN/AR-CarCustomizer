using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }
    public void InideCar()
    {
        SceneManager.LoadScene("insideCar");
    }
    public void QuitScene()
    {
        Application.Quit();
    }
}
