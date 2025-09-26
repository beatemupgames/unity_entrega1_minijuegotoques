using Unity.VisualScripting;
using UnityEngine;

public class Balon : MonoBehaviour
{
    private GameObject panelDerrota;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Asignar a panelDerrota el GameObject PanelDerrota
        panelDerrota = (GameObject)GameObject.FindGameObjectWithTag("PanelDerrota");

        // Ocultar panelDerrota
        panelDerrota.SetActive(false);
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
            // Extra: bloquear el movimiento de Player2D
    
            GameObject player2D = GameObject.FindWithTag("Player2D");

            if (player2D != null)
                player2D.GetComponent<Player2D>().enabled = false;


            // Hacer visible panelDerrota

            panelDerrota.SetActive(true);


            // Destruir este Game Object

            Destroy(this.gameObject);
        }
    } 
}
