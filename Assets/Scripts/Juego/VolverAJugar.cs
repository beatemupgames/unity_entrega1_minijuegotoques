using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para poder cargar otras escenas

public class VolverAJugar : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("Juego");
    }
}
