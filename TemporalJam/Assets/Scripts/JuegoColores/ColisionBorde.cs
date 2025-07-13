using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ColisionBorde : MonoBehaviour
{
    public GameObject barraInferior, manager;

    private SpriteRenderer Barra, Barra2;

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
        NuevoManager m = manager.GetComponent<NuevoManager>();

        if(m.colorbarra == 1)
        {
            if (((Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.D)) || (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.S))) || (Input.GetKeyDown(KeyCode.I) && Input.GetKey(KeyCode.O)) || (Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.I))) //rojo-amarillo
            {
                Color c;
                ColorUtility.TryParseHtmlString("#FFA500", out c); //Naranja
                Barra.color = c;
                ry = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.S)) || (Input.GetKeyDown(KeyCode.I) && Input.GetKey(KeyCode.U) || Input.GetKeyDown(KeyCode.U) && Input.GetKey(KeyCode.I))) //rojo-azul
            {
                Color c;
                ColorUtility.TryParseHtmlString("#D207F6", out c); //violeta
                Barra.color = c;

                rb = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.F) || Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.S)) || (Input.GetKeyDown(KeyCode.I) && Input.GetKey(KeyCode.P) || Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.I))) //rojo-verde
            {
                Color c;
                ColorUtility.TryParseHtmlString("#CBB22A", out c); //Amarillo raro
                Barra.color = c;

                rg = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.A)) || (Input.GetKeyDown(KeyCode.U) && Input.GetKey(KeyCode.O) || Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.U))) //azul-amarillo
            {
                Color c;
                ColorUtility.TryParseHtmlString("#8BD765", out c); //Verde raro
                Barra.color = c;

                by = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.F) || Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.A)) || (Input.GetKeyDown(KeyCode.U) && Input.GetKey(KeyCode.P) || Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.U))) //azul-verde
            {
                Color c;
                ColorUtility.TryParseHtmlString("#14F69E", out c); //Verde azulado
                Barra.color = c;

                bg = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.F) || Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.D)) || (Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.P) || Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.O))) //amarillo-verde
            {
                Color c;
                ColorUtility.TryParseHtmlString("#B1FF00", out c); //Amarillo verdoso
                Barra.color = c;

                yg = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.U)) //Azul
            {
                Barra.color = Color.cyan;
                b = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.I)) //Rojo
            {
                Barra.color = Color.red;
                r = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.O)) //Amarillo
            {
                Barra.color = Color.yellow;
                y = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.P)) //Verde
            {
                Barra.color = Color.green;
                g = true;
                StartCoroutine(VueltaBlanco());
                return;
            }
        }

        //Jugador 2
        if(m.colorbarra == 2)
        {
            if (((Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.D)) || (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.S))) || (Input.GetKeyDown(KeyCode.I) && Input.GetKey(KeyCode.O)) || (Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.I))) //rojo-amarillo
            {
                Color c;
                ColorUtility.TryParseHtmlString("#FFA500", out c); //Naranja
                Barra.color = c;
                ry = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.S)) || (Input.GetKeyDown(KeyCode.I) && Input.GetKey(KeyCode.U) || Input.GetKeyDown(KeyCode.U) && Input.GetKey(KeyCode.I))) //rojo-azul
            {
                Color c;
                ColorUtility.TryParseHtmlString("#D207F6", out c); //violeta
                Barra.color = c;

                rb = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.F) || Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.S)) || (Input.GetKeyDown(KeyCode.I) && Input.GetKey(KeyCode.P) || Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.I))) //rojo-verde
            {
                Color c;
                ColorUtility.TryParseHtmlString("#CBB22A", out c); //Amarillo raro
                Barra.color = c;

                rg = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.A)) || (Input.GetKeyDown(KeyCode.U) && Input.GetKey(KeyCode.O) || Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.U))) //azul-amarillo
            {
                Color c;
                ColorUtility.TryParseHtmlString("#8BD765", out c); //Verde raro
                Barra.color = c;

                by = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.F) || Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.A)) || (Input.GetKeyDown(KeyCode.U) && Input.GetKey(KeyCode.P) || Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.U))) //azul-verde
            {
                Color c;
                ColorUtility.TryParseHtmlString("#14F69E", out c); //Verde azulado
                Barra.color = c;

                bg = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if ((Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.F) || Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.D)) || (Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.P) || Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.O))) //amarillo-verde
            {
                Color c;
                ColorUtility.TryParseHtmlString("#B1FF00", out c); //Amarillo verdoso
                Barra.color = c;

                yg = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.U)) //Azul
            {
                Barra.color = Color.cyan;
                b = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.I)) //Rojo
            {
                Barra.color = Color.red;
                r = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.O)) //Amarillo
            {
                Barra.color = Color.yellow;
                y = true;
                StartCoroutine(VueltaBlanco());
                return;
            }

            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.P)) //Verde
            {
                Barra.color = Color.green;
                g = true;
                StartCoroutine(VueltaBlanco());
                return;
            }
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
        ry = false;
        rb = false;
        rg = false;
        by = false;
        bg = false;
        yg = false;
    }
}
