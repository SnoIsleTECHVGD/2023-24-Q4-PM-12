using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditSwitch : MonoBehaviour
{
    public void Credits()
    {
        SceneManager.LoadScene("AliahCS");
    }

    public void titleScreen()
    {
        SceneManager.LoadScene("MainLevel");
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
}
