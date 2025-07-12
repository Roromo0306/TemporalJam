using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoManager : MonoBehaviour
{
    public GameObject gen1, gen2, gen3, gen4, rojo, azul, amarillo, verde;

    public float puntos;
    public int bloque, doble, dobleC, lugarGeneracion;
    void Start()
    {
        InvokeRepeating("generacion", 0f, 2f);
    }


    void Update()
    {

    }

    void generacion()
    {
        bloque = Random.Range(1, 5);
        doble = Random.Range(0, 4);
        dobleC = Random.Range(1, 7);
        lugarGeneracion = Random.Range(0, 4);

        if (doble == 0 || doble == 1 || doble == 2)
        {
            if (bloque == 1)
            {
                Instantiate(rojo, gen1.transform);
            }

            if (bloque == 2)
            {
                Instantiate(azul, gen2.transform);
            }

            if (bloque == 3)
            {
                Instantiate(amarillo, gen3.transform);
            }

            if (bloque == 4)
            {
                Instantiate(verde, gen4.transform);
            }
        }

        if (doble == 3)
        {
            if (dobleC == 1)
            {
                Instantiate(rojo, gen1.transform);
                Instantiate(amarillo, gen3.transform);
            }

            if (dobleC == 2)
            {
                Instantiate(rojo, gen1.transform);
                Instantiate(azul, gen2.transform);
            }

            if (dobleC == 3)
            {
                Instantiate(rojo, gen1.transform);
                Instantiate(verde, gen4.transform);
            }

            if (dobleC == 4)
            {
                Instantiate(azul, gen2.transform);
                Instantiate(amarillo, gen3.transform);
            }

            if (dobleC == 5)
            {
                Instantiate(azul, gen2.transform);
                Instantiate(verde, gen4.transform);
            }

            if (dobleC == 6)
            {
                Instantiate(amarillo, gen3.transform);
                Instantiate(verde, gen4.transform);
            }
        }
    }
}
