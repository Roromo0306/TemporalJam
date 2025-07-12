using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ColisionBorde : MonoBehaviour
{
    public GameObject barraInferior, manager;

    private SpriteRenderer Barra;

    [HideInInspector] public bool r = false, b = false, y = false, g=false, ry=false, rb = false, rg =false, by=false, bg=false, yg=false;
    public int combo = 0;

    public float tiempoCaida = 0.5f;
    public float multiplicador1 = 1.5f, multiplicador2 = 2f, multiplicador3 = 2.5f;
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


        if ((Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)) || (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))) //rojo-amarillo
        {
            Color c;
            ColorUtility.TryParseHtmlString("#FFA500", out c); //Naranja
            Barra.color = c;
            Debug.Log($"Color asignado: {c} (alpha={c.a})");
            ry = true;
            StartCoroutine(VueltaBlanco());
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)) //rojo-azul
        {
            Color c;
            ColorUtility.TryParseHtmlString("#D207F6", out c); //violeta
            Barra.color = c;

            rb = true;
            StartCoroutine(VueltaBlanco());
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow)) //rojo-verde
        {
            Color c;
            ColorUtility.TryParseHtmlString("#CBB22A", out c); //Amarillo raro
            Barra.color = c;

            rg = true;
            StartCoroutine(VueltaBlanco());
            return;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow)) //azul-amarillo
        {
            Color c;
            ColorUtility.TryParseHtmlString("#8BD765", out c); //Verde raro
            Barra.color = c;

            by = true;
            StartCoroutine(VueltaBlanco());
            return;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow)) //azul-verde
        {
            Color c;
            ColorUtility.TryParseHtmlString("#14F69E", out c); //Verde azulado
            Barra.color = c;

            bg = true;
            StartCoroutine(VueltaBlanco());
            return;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)) //amarillo-verde
        {
            Color c;
            ColorUtility.TryParseHtmlString("#B1FF00", out c); //Amarillo verdoso
            Barra.color = c;

            yg = true;
            StartCoroutine(VueltaBlanco());
            return;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //Azul
        {
            Barra.color = Color.cyan;
            b = true;
            StartCoroutine(VueltaBlanco());
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) //Rojo
        {
            Barra.color = Color.red;
            r = true;
            StartCoroutine(VueltaBlanco());
            return;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) //Amarillo
        {
            Barra.color = Color.yellow;
            y = true;
            StartCoroutine(VueltaBlanco());
            return;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow)) //Verde
        {
            Barra.color = Color.green;
            g = true;
            StartCoroutine(VueltaBlanco());
            return;
        }
    }

    //Corrutina para volver la barra blanca
    IEnumerator VueltaBlanco()
    {
        yield return new WaitForSeconds(tiempoCaida);
        Barra.color = Color.white;
        r = false;
        b = false;
        y = false;
        g= false;
    }
}
