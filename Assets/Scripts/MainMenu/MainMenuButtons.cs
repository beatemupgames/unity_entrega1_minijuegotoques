using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para poder cargar otras escenas

public class MainMenuButtons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quit()
    {
        #if UNITY_EDITOR
            // Esto detiene la ejecución en el Editor
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // Esto funciona en la Build
            Application.Quit();
        #endif
    }
}
