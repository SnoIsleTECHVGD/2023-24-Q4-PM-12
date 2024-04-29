using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditSwitch : MonoBehaviour
{
    public void titleScreen()
    {
        SceneManager.LoadScene("LevelTest");
    }
    public void Credits()
    {
        SceneManager.LoadScene("AliahCS");
    }

    public void Credits2()
    {
        SceneManager.LoadScene("JonasCS");
    }

    public void Credits3()
    {
        SceneManager.LoadScene("JayCS");
    }

    public void Credits4()
    {
        SceneManager.LoadScene("BrandonCS");
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
