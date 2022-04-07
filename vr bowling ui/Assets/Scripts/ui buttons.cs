using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uibuttons : MonoBehaviour
{
    public void LoadTutScene()
    {
        SceneManager.LoadScene("tutorial");
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("app has been quitted");
    }
    
}
