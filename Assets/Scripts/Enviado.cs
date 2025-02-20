using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enviado : MonoBehaviour
{
    // Arrastra aqu� el objeto que deseas mostrar (Cartelenviado).
    public GameObject cartelenviado;

    public void ShowMessage()
    {
        if (cartelenviado != null)
        {
            // Aseg�rate de que el objeto est� activo.
            cartelenviado.SetActive(true);
        }
        else
        {
            Debug.LogWarning("El objeto Cartelenviado no est� asignado en el inspector.");
        }
    }
}
