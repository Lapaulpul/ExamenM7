using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SistemaRecolector : MonoBehaviour
{
    public int cantidadMonedas;
    public TextMeshProUGUI numero;

    private void Update()
    {
        numero.text = cantidadMonedas.ToString();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Moneda"))
        {
            Destroy(other.gameObject);
            cantidadMonedas++;
        }
    }
}
