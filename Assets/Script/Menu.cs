using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Offical_Openning");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
