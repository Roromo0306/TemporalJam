using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBorde : MonoBehaviour
{
    public GameObject barraInferior, manager;

    private SpriteRenderer Barra;

    private bool r = false, b = false, y = false;
    void Start()
    {
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
            b = true;
            StartCoroutine(VueltaBlanco());
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Barra.color = Color.red;
            r = true;
            StartCoroutine(VueltaBlanco());
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Barra.color = Color.yellow;
            y = true;
            StartCoroutine(VueltaBlanco());
        }
    }

    //Corrutina para volver la barra blanca
    IEnumerator VueltaBlanco()
    {
        yield return new WaitForSeconds(0.5f);
        Barra.color = Color.white;
        r = false;
        b = false;
        y = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        JuegoColores j = manager.GetComponent<JuegoColores>();
        if(collision.gameObject.name == "Rojo(Clone)")
        {
            if (r)
            {
                j.puntos +=1;
            }
            else
            {
                j.puntos -= 1;
            }
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Azul(Clone)")
        {
            if (b)
            {
                j.puntos += 1;
            }
            else
            {
                j.puntos -= 1;
            }
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Amarillo(Clone)")
        {
            if (y)
            {
                j.puntos += 1;
            }
            else
            {
                j.puntos -= 1;
            }
            Destroy(collision.gameObject);
        }
    }
}
