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
        SceneManager.LoadScene("Tutorial");
    }
    public void OnCredits()
    {
        SceneManager.LoadScene("CreditScreen");
    }
    public void OnMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void OnResume()
    {
        JimmyAniamtion.inPause = false;
    }
}


