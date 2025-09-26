using Unity.VisualScripting;
using UnityEngine;

public class Balon : MonoBehaviour
{

    private GameObject panelDerrota;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panelDerrota = (GameObject)GameObject.FindGameObjectWithTag("PanelDerrota");

        //if (panelDerrota) print("Existe");
        panelDerrota.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SensorDeDerrota")
        {
            //print("Has perdido");
            panelDerrota.SetActive(true);
            Destroy(this.gameObject);
        }
    } 
}
