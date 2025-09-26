using UnityEngine;
using TMPro; // Necesario para acceder al componente TextMeshPro de PuntuacionUI

public class Player2D : MonoBehaviour
{
    [SerializeField]
    private float velocidad;
    private int puntuacion;

    [SerializeField]
    private GameObject puntuacionUI;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Inicializar la puntuación

        this.puntuacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Desplazar este Game Object al detectar una pulsación en A, D, flecha izquierda o flecha derecha
        // --> Multiplicarlo por la variable con la velocidad y ajustarlo al framerate

        this.gameObject.transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, 0.0f, 0.0f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Si el objeto que colisiona con este es Balon
        // --> Incrementar la puntuación en uno
        // --> Mostrar la puntuación en pantalla

        if (other.gameObject.tag == "Balon")
        {
            puntuacion++;
            puntuacionUI.gameObject.GetComponent<TMP_Text>().text = "Score: " + puntuacion.ToString();


            /*if(other.gameObject.GetComponent<Rigidbody2D>().gravityScale < 4.0f)
                other.gameObject.GetComponent<Rigidbody2D>().gravityScale += 0.25f;

            print(other.gameObject.GetComponent<Rigidbody2D>().gravityScale);*/
        }
    }
}
