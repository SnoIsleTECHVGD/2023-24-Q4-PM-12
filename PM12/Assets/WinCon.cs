using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winCon();
    }
    public void winCon()
    {
        SceneManager.LoadScene("Win Screen");
    }
}
