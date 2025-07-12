using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ColisionBorde : MonoBehaviour
{
    public GameObject barraInferior, manager;

    private SpriteRenderer Barra;

    [HideInInspector] public bool r = false, b = false, y = false, g=false;
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

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Barra.color = Color.green;
            g = true;
            StartCoroutine(VueltaBlanco());
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
