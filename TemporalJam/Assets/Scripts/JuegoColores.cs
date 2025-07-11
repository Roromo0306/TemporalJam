using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuegoColores : MonoBehaviour
{
    public GameObject gen1, gen2, gen3, rojo, azul, amarillo, barraInferior;

    public int puntos;
    public int lugarGeneracion, bloque;

    private SpriteRenderer Barra;
    void Start()
    {
        InvokeRepeating("generacion", 0f, 3f); 
        Barra = barraInferior.GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {
        CambioColor();
    }

    //Funcion que cambia el color de la barra al pulsar una tecla
    private void CambioColor()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Barra.color = Color.cyan;
            StartCoroutine(VueltaBlanco());
        }
    }

    //Corrutina para volver la barra blanca
    IEnumerator VueltaBlanco()
    {
        yield return new WaitForSeconds(0.5f);
        Barra.color = Color.white;
    }

    //Funcion que genera los cuadrados en sus generadores
    void generacion()
    {
        lugarGeneracion = Random.Range(1, 4);
        bloque = Random.Range(1, 4);

        if(lugarGeneracion == 1)
        {
            if(bloque == 1)
            {
                Instantiate(rojo, gen1.transform);
            }

            if (bloque == 2)
            {
                Instantiate(azul, gen1.transform);
            }

            if (bloque == 3)
            {
                Instantiate(amarillo, gen1.transform);
            }
        }

        if (lugarGeneracion == 2)
        {
            if (bloque == 1)
            {
                Instantiate(rojo, gen2.transform);
            }

            if (bloque == 2)
            {
                Instantiate(azul, gen2.transform);
            }

            if (bloque == 3)
            {
                Instantiate(amarillo, gen2.transform);
            }
        }

        if (lugarGeneracion == 3)
        {
            if (bloque == 1)
            {
                Instantiate(rojo, gen3.transform);
            }

            if (bloque == 2)
            {
                Instantiate(azul, gen3.transform);
            }

            if (bloque == 3)
            {
                Instantiate(amarillo, gen3.transform);
            }
        }

        
    }
}
