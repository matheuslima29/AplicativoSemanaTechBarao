using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoToCredits()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void GoToAbertura()
    {
        SceneManager.LoadScene("AberturaMKT");
    }

    public void GoToPalestra1()
    {
        SceneManager.LoadScene("Palestras1");
    }

    public void GoToPalestra2()
    {
        SceneManager.LoadScene("Palestras2");
    }

    public void GoToOficina1()
    {
        SceneManager.LoadScene("Oficinas1");
    }

    public void GoToOficina2()
    {
        SceneManager.LoadScene("Oficinas2");
    }

    public void GoToLogin()
    {
        SceneManager.LoadScene("Login");
    }

    public void GoToEventList()
    {
        SceneManager.LoadScene("EventList");
    }

    public void GoToCineBarao()
    {
        SceneManager.LoadScene("CineBarao");
    }
}
