using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void iniciar()
    {

        SceneManager.LoadScene("QuizNivel");
    }

    public void salir()
    {

        SceneManager.LoadScene("MenuMinijuego");
    }

    public void integrantesssss()
    {

        SceneManager.LoadScene("Integrantes");
    }

}
