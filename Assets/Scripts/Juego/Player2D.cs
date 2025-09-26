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
        this.puntuacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.D))
        this.gameObject.transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, 0.0f, 0.0f);
        /*else if (Input.GetKey(KeyCode.A))
            this.gameObject.transform.Translate(-velocidad * Time.deltaTime, 0.0f, 0.0f);*/
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Balon")
        {
            puntuacion++;
            puntuacionUI.gameObject.GetComponent<TMP_Text>().text = puntuacion.ToString();
        }
    }
}
