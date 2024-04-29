using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCon : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        loseCon();
    }
    public void loseCon()
    {
        SceneManager.LoadScene(sceneName);
    }
}
