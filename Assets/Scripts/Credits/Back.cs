using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para poder cargar otras escenas

public class Back : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
