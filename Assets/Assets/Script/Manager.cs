using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    
    private bool elijeCirculo, elijeCuadrado;
    public GameObject moldeRedondo, moldeCuadrado, botones;
   
    void Start()
    {
        elijeCirculo = false;
        elijeCuadrado = false;              
    }

  
  
    
    // Update is called once per frame
    void Update()
    {
        

        if (elijeCuadrado == true)
        {
            elijeCirculo = false;
            moldeCuadrado.SetActive(true);
            botones.SetActive(false);
        }
        if (elijeCirculo == true)
        {
            elijeCuadrado = false;
            moldeRedondo.SetActive(true);
            botones.SetActive(false);
           
        }
        /*
            
         * 
        if (elijeCuadrado == true)
        {
            elijeCirculo = false;
            moldeRedondo.SetActive(false);
            moldeCuadrado.SetActive(true);
        }
        if()
        {
            elijeCuadrado = false;
            
            moldeCuadrado.SetActive(false);
            moldeRedondo.SetActive(true);
        }
        */
    }
   

    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
    public void EscenaCreditos()
    {
        
        SceneManager.LoadScene("MenuCreditos");
    }
    public void EleccionRedondo()
    {
        elijeCuadrado = false;
        elijeCirculo = true;
       

    }
    public void EleccionCuadrado()
    {
        elijeCirculo = false;
        elijeCuadrado = true;
        

    }
    public void Salir()
    {
        Application.Quit();
    }
}