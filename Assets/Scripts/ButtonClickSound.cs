using UnityEngine;
using UnityEngine.UI;  // Necesario para trabajar con el sistema UI de Unity

public class ButtonClickSound : MonoBehaviour
{
    public AudioClip clickSound;  // Para almacenar el sonido que quieres reproducir
    public AudioSource audioSource;  // Componente para reproducir audio

    void Start()
    {
        // Obtener el componente AudioSource del objeto en el que est� el script
        audioSource = GetComponent<AudioSource>();

        // Si no hay AudioSource, lo a�adimos
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Buscar el bot�n en la escena y asignarle el evento de clic
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);  // A�adir el listener
        }
    }

    void OnButtonClick()
    {
        // Reproducir el sonido cuando se hace clic en el bot�n
        if (clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}

