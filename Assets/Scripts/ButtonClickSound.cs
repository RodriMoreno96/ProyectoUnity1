using UnityEngine;
using UnityEngine.UI;  // Necesario para trabajar con el sistema UI de Unity

public class ButtonClickSound : MonoBehaviour
{
    public AudioClip clickSound;  // Para almacenar el sonido que quieres reproducir
    public AudioSource audioSource;  // Componente para reproducir audio

    void Start()
    {
        // Obtener el componente AudioSource del objeto en el que está el script
        audioSource = GetComponent<AudioSource>();

        // Si no hay AudioSource, lo añadimos
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Buscar el botón en la escena y asignarle el evento de clic
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);  // Añadir el listener
        }
    }

    void OnButtonClick()
    {
        // Reproducir el sonido cuando se hace clic en el botón
        if (clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}

