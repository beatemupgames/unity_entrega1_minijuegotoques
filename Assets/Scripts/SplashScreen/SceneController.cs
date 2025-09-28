using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class SceneController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("LoadNextScene", 3.0f);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
