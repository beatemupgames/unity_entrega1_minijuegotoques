using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para poder cargar otras escenas

public class BackToMainMenu : MonoBehaviour
{
    public void BackToMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
