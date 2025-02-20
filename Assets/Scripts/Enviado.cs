using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enviado : MonoBehaviour
{
    // Arrastra aquí el objeto que deseas mostrar (Cartelenviado).
    public GameObject cartelenviado;

    public void ShowMessage()
    {
        if (cartelenviado != null)
        {
            // Asegúrate de que el objeto esté activo.
            cartelenviado.SetActive(true);
        }
        else
        {
            Debug.LogWarning("El objeto Cartelenviado no está asignado en el inspector.");
        }
    }
}
