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

}
