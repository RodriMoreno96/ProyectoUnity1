using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Agregar esta línea para usar la UI

[RequireComponent(typeof(AudioSource))]

public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioClip m_correctSound = null;
    [SerializeField] private AudioClip m_incorrectSound = null;
    [SerializeField] private Color m_correctColor = Color.black;
    [SerializeField] private Color m_incorrectColor = Color.black;
    [SerializeField] private float m_waitTime = 0.0f;

    private QuizDB m_quizDB = null;
    private QuizUI m_quizUI = null;

    private AudioSource m_audioSource = null;

    public float tiempoEspera = 3f;
    private int correctAnswers = 0;    // Contador de respuestas correctas
    private int lives = 3;             // Contador de vidas

    // Referencias a los elementos de texto de UI
    [SerializeField] private Text correctAnswersText;
    [SerializeField] private Text livesText;

    private void Start()
    {
        m_quizDB = GameObject.FindObjectOfType<QuizDB>();
        m_quizUI = GameObject.FindObjectOfType<QuizUI>();
        m_audioSource = GetComponent<AudioSource>();

        UpdateUI(); // Actualizar la UI al inicio
        NextQuestion();
    }

    private void NextQuestion()
    {
        m_quizUI.Construtc(m_quizDB.GetRandom(), GiveAnswer);
    }

    private void GiveAnswer(OptionButton optionButton)
    {
        StartCoroutine(GiveAnswerRoutine(optionButton));
    }

    private IEnumerator GiveAnswerRoutine(OptionButton optionButton)
    {
        if (m_audioSource.isPlaying)
        {
            m_audioSource.Stop();
        }
        m_audioSource.clip = optionButton.Option.correct ? m_correctSound : m_incorrectSound;
        optionButton.SetColor(optionButton.Option.correct ? m_correctColor : m_incorrectColor);

        m_audioSource.Play();

        yield return new WaitForSeconds(m_waitTime);

        if (optionButton.Option.correct)
        {
            correctAnswers++;  // Incrementar el contador de respuestas correctas
            if (correctAnswers >= 5)
            {
                Victory();  // Si alcanza 5 respuestas correctas, ir a la escena de victoria
            }
            else
            {
                UpdateUI(); // Actualizar la UI después de una respuesta correcta
                NextQuestion();  // Si aún no se han alcanzado 5, continuar con la siguiente pregunta
            }
        }
        else
        {
            lives--;  // Reducir el contador de vidas
            UpdateUI(); // Actualizar la UI después de una respuesta incorrecta
            if (lives <= 0)
            {
                GameOver();  // Si las vidas llegan a 0, ir a la escena de Game Over
            }
            else
            {
                yield return new WaitForSeconds(tiempoEspera);
            }
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");  // Cargar la escena de Game Over
    }

    private void Victory()
    {
        SceneManager.LoadScene("VictoryScene");  // Cargar la escena de Victoria
    }

    // Método para actualizar la UI de texto
    private void UpdateUI()
    {
        correctAnswersText.text = "Respuestas Correctas: " + correctAnswers;
        livesText.text = "Vidas: " + lives;
    }
}

