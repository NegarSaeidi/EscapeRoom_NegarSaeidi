using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void OnExit()
    {
        Application.Quit();
    }
    public void OnPlay()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnTutorial()
    {

    }
    public void OnCredits()
    {

    }
}


