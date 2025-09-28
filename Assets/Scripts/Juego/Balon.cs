using Unity.VisualScripting;
using UnityEngine;

public class Balon : MonoBehaviour
{
    private GameObject panelDerrota;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Asignar a panelDerrota el GameObject PanelDerrota

        panelDerrota = (GameObject) GameObject.FindGameObjectWithTag("PanelDerrota");


        // Ocultar panelDerrota

        panelDerrota.SetActive(false);


        // Extra: añadir un impulso horizontal a Balon para que no sea tan trivial jugar
        // --> Crear una variable de tipo float con un valor aleatorio entre -2 y 2
        // --> Crear un Vector2 con el float anterior como valor x
        // --> Aplicar velocidad lineal al Rigidbody2D usando la variable de tipo Vector2

        float impulsoX = Random.Range(-2.0f, 2.0f);
        Vector2 impulsoInicial = new Vector2(impulsoX, 0.0f);
        this.gameObject.GetComponent<Rigidbody2D>().linearVelocity = impulsoInicial;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Si el objeto que colisiona con este es SensorDeDerrota

        if (other.gameObject.tag == "SensorDeDerrota")
        {
            // Extra: bloquear el movimiento de Player2D tras finalizar una partida
            // --> El usuario no podrá mover Player2D una vez haya perdido
    
            GameObject player2D = (GameObject) GameObject.FindGameObjectWithTag("Player2D");

            if (player2D != null)
                player2D.GetComponent<Player2D>().enabled = false;


            // Hacer visible panelDerrota

            panelDerrota.SetActive(true);


            // Destruir este Game Object

            Destroy(this.gameObject);
        }
    } 
}
